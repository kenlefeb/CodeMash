using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.Specialized;
using System.Net;
using System.Diagnostics.Contracts;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item templates.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace Spakll.CodeMash.Data
{
    public sealed class CodeMashData
    {
        public CodeMashData()
        {
            this.AllTechnologies = new ObservableCollection<Technology>();
            ServiceUri = new Uri("http://rest.codemash.org/api/sessions.json");
            Load(ServiceUri);
        }

        public static CodeMashData Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly CodeMashData instance = new CodeMashData();
        }

        public ObservableCollection<Technology> AllTechnologies { get; private set; }

        public IEnumerable<Technology> GetTechnologies()
        {
            return this.AllTechnologies;
        }

        public Technology GetTechnology(string uniqueId)
        {
            var matches = this.AllTechnologies.Where(t => t.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        public Session GetSession(string uniqueId)
        {
            var matches = this.AllTechnologies.SelectMany(t => t.Sessions).Where(s => s.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        public DateTime? Loaded { get; private set; }

        public void Load(Uri source)
        {
            this.Loaded = null;

            AllTechnologies.Clear();

            var request = HttpWebRequest.CreateHttp(source);
            var task = Task.Run<WebResponse>(() => request.GetResponseAsync());
            var response = task.Result as HttpWebResponse;
            var content = response.GetResponseStream();

            Contract.Assert(response.StatusCode == HttpStatusCode.OK);
            Contract.Assert(response.ContentType.StartsWith("application/json"));

            var json = new StreamReader(content).ReadToEnd();
            var sessions = JArray.Parse(json);

            var technologyTokens = sessions.Select(s => s["Technology"]).Distinct();

            foreach (var technologyToken in technologyTokens)
            {
                var trackSessions = sessions.Where(s => s.Value<string>("Technology") == technologyToken.ToString());
                var technology = new Technology(technologyToken);
                technology.AddSessions(trackSessions.Select<JToken, Session>(s => new Session(s, technology)));
                AllTechnologies.Add(technology);
            }

            Contract.Assert(AllTechnologies.Count > 0);

            this.Loaded = DateTime.Now;
        }

        public Uri ServiceUri { get; set; }
    }
}

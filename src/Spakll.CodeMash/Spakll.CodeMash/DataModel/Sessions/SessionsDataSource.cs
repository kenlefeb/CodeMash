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

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item templates.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace Spakll.CodeMash.Data
{

    /// <summary>
    /// Creates a collection of groups and items with hard-coded content.
    /// 
    /// SampleDataSource initializes with placeholder data rather than live production
    /// data so that sample data is provided at both design-time and run-time.
    /// </summary>
    public sealed class SessionsDataSource
    {
        private static SessionsDataSource _sampleDataSource = new SessionsDataSource();

        private ObservableCollection<Track> _allGroups = new ObservableCollection<Track>();
        public ObservableCollection<Track> AllGroups
        {
            get { return this._allGroups; }
        }

        public static IEnumerable<Track> GetGroups(string uniqueId)
        {
            if (!uniqueId.Equals("AllGroups")) throw new ArgumentException("Only 'AllGroups' is supported as a collection of groups");
            
            return _sampleDataSource.AllGroups;
        }

        public static Track GetGroup(string uniqueId)
        {
            // Simple linear search is acceptable for small data sets
            var matches = _sampleDataSource.AllGroups.Where((group) => group.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        public static Session GetItem(string uniqueId)
        {
            // Simple linear search is acceptable for small data sets
            var matches = _sampleDataSource.AllGroups.SelectMany(group => group.Items).Where((item) => item.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        private async void Load(Uri source)
        {
            var request = HttpWebRequest.CreateHttp(source);
            var response = await request.GetResponseAsync() as HttpWebResponse;
            var content = response.GetResponseStream();

            Contract.Assert(response.StatusCode == HttpStatusCode.OK);
            Contract.Assert(response.ContentType.StartsWith("application/json"));

            var json = new StreamReader(content).ReadToEnd();
            var sessions = JsonConvert.DeserializeObject<Session[]>(json);

            Contract.Assert(sessions.Length > 0);
        }
        public SessionsDataSource()
        {
            Load(new Uri("http://rest.codemash.org/api/sessions.json"));
        }
    }
}

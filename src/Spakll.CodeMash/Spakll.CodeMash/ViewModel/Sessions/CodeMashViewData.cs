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
using Spakll.CodeMash.Data;
using System.Threading.Tasks;

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item templates.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace Spakll.CodeMash.ViewModel.Sessions
{
    public sealed class CodeMashViewData
    {
        CodeMashViewData()
        {
            GetTechnologyGroups();
        }

        public static CodeMashViewData Instance
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

            internal static readonly CodeMashViewData instance = new CodeMashViewData();
        }

        public ObservableCollection<TechnologiesView> AllTechnologyGroups { get; private set; }
        public ObservableCollection<TechnologyView> AllTechnologies { get; private set; }

        public IEnumerable<TechnologiesView> GetTechnologyGroups()
        {
            var technologies = GetTechnologies().OrderBy(t => t.GroupName);
            AllTechnologyGroups = new ObservableCollection<TechnologiesView>();
            foreach (var technology in technologies)
            {
                var group = AllTechnologyGroups.FirstOrDefault(g => g.Title == technology.GroupName);
                if (group == null)
                {
                    group = new TechnologiesView { Title = technology.GroupName };
                    AllTechnologyGroups.Add(group);
                }
                group.Technologies.Add(technology);
            }
            return AllTechnologyGroups;
        }

        public IEnumerable<TechnologyView> GetTechnologies()
        {
            return CodeMashData.Instance.GetTechnologies().Select<Technology, TechnologyView>(t => new TechnologyView(t));
        }

        public TechnologyView GetTechnology(string uniqueId)
        {
            return new TechnologyView(CodeMashData.Instance.GetTechnology(uniqueId));
        }

        public IEnumerable<SessionsView> GetSessionGroups(Technology technology)
        {
            var sessions = GetSessions(technology).OrderBy(s => s.GroupName);
            var groups = new ObservableCollection<SessionsView>();

            foreach (var session in sessions)
            {
                var group = groups.FirstOrDefault(g => g.Title == session.GroupName);
                if (group == null)
                {
                    group = new SessionsView { Title = session.GroupName };
                    groups.Add(group);
                }
                group.Sessions.Add(session);
            }
            return groups;
        }

        public IEnumerable<SessionView> GetSessions(Technology technology)
        {
            return technology.Sessions.Select<Session, SessionView>(s => new SessionView(s));
        }
        public Session GetSession(string uniqueId)
        {
            return CodeMashData.Instance.GetSession(uniqueId);
        }

        public DateTime? Loaded
        {
            get { return CodeMashData.Instance.Loaded; }
        }

        public async void Load(Uri source)
        {
            await Task.Run(() => CodeMashData.Instance.Load(source));
        }

        public Uri ServiceUri
        {
            get { return CodeMashData.Instance.ServiceUri; }
            set { CodeMashData.Instance.ServiceUri = value; }
        }

    }
}

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
        CodeMashViewData() { }

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

        public ObservableCollection<TechnologyView> AllTechnologies { get; private set; }

        public IEnumerable<GroupView> GetGroups()
        {
            var technologies = GetTechnologies().OrderBy(t => t.GroupName);
            var list = new List<GroupView>();
            foreach (var technology in technologies)
            {
                var group = list.FirstOrDefault(g => g.Title == technology.GroupName);
                if (group == null)
                {
                    group = new GroupView { Title = technology.GroupName };
                    list.Add(group);
                }
                group.Technologies.Add(technology);
            }
            return list;
        }

        public IEnumerable<TechnologyView> GetTechnologies()
        {
            return CodeMashData.Instance.GetTechnologies().Select<Technology, TechnologyView>(t => new TechnologyView(t));
        }

        public TechnologyView GetTechnology(string uniqueId)
        {
            return new TechnologyView(CodeMashData.Instance.GetTechnology(uniqueId));
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

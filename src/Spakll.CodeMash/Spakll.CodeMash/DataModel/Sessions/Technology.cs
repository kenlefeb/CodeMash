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

namespace Spakll.CodeMash.Data
{
    /// <summary>
    /// Generic group data model.
    /// </summary>
    public class Technology : NavigableItem
    {
        public Technology(String uniqueId, String title, String subtitle, String imagePath, String description)
            : base(uniqueId, title, subtitle, imagePath, description)
        {
            Sessions.CollectionChanged += ItemsCollectionChanged;
        }

        public Technology(Newtonsoft.Json.Linq.JToken technologyToken)
        {
            this.Title = technologyToken.ToString();
            this.Description = string.Format("Sessions about {0}", Title);
            this.UniqueId = string.Format("Technology-{0}", Title);
        }

        public void AddSessions(IEnumerable<Session> sessions)
        {
            foreach (var session in sessions) Sessions.Add(session);
        }

        private void ItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Provides a subset of the full items collection to bind to from a GroupedItemsPage
            // for two reasons: GridView will not virtualize large items collections, and it
            // improves the user experience when browsing through groups with large numbers of
            // items.
            //
            // A maximum of 12 items are displayed because it results in filled grid columns
            // whether there are 1, 2, 3, 4, or 6 rows displayed

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewStartingIndex < 12)
                    {
                        TopSessions.Insert(e.NewStartingIndex, Sessions[e.NewStartingIndex]);
                        if (TopSessions.Count > 12)
                        {
                            TopSessions.RemoveAt(12);
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Move:
                    if (e.OldStartingIndex < 12 && e.NewStartingIndex < 12)
                    {
                        TopSessions.Move(e.OldStartingIndex, e.NewStartingIndex);
                    }
                    else if (e.OldStartingIndex < 12)
                    {
                        TopSessions.RemoveAt(e.OldStartingIndex);
                        TopSessions.Add(Sessions[11]);
                    }
                    else if (e.NewStartingIndex < 12)
                    {
                        TopSessions.Insert(e.NewStartingIndex, Sessions[e.NewStartingIndex]);
                        TopSessions.RemoveAt(12);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldStartingIndex < 12)
                    {
                        TopSessions.RemoveAt(e.OldStartingIndex);
                        if (Sessions.Count >= 12)
                        {
                            TopSessions.Add(Sessions[11]);
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    if (e.OldStartingIndex < 12)
                    {
                        TopSessions[e.OldStartingIndex] = Sessions[e.OldStartingIndex];
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    TopSessions.Clear();
                    while (TopSessions.Count < Sessions.Count && TopSessions.Count < 12)
                    {
                        TopSessions.Add(Sessions[TopSessions.Count]);
                    }
                    break;
            }
        }

        private ObservableCollection<Session> _sessions = new ObservableCollection<Session>();
        public ObservableCollection<Session> Sessions
        {
            get { return this._sessions; }
        }

        private ObservableCollection<Session> _topSessions = new ObservableCollection<Session>();
        public ObservableCollection<Session> TopSessions
        {
            get { return this._topSessions; }
        }
    }
}

using Spakll.CodeMash.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spakll.CodeMash.ViewModel.Sessions
{
    public class SessionsView : NavigableItem
    {
        public SessionsView()
        {
            Sessions = new List<SessionView>();
        }

        public IList<SessionView> Sessions { get; private set; }
    }
}

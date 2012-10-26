using Spakll.CodeMash.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Spakll.CodeMash.ViewModel.Sessions
{
    public class SessionView : Session
    {
        public SessionView(Session session)
            : base(session.UniqueId, session.Title, session.Subtitle, "", session.Description)
        {
            Difficulty = session.Difficulty;
        }

        public string GroupName
        {
            get
            {
                return base.Difficulty;
            }
        }
    }
}

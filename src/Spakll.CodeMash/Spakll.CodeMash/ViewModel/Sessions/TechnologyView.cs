using Spakll.CodeMash.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Spakll.CodeMash.ViewModel.Sessions
{
    public class TechnologyView : Technology
    {
        public TechnologyView(Technology technology)
            : base(technology.UniqueId, technology.Title, technology.Subtitle, "", technology.Description)
        {
        }

        public string GroupName
        {
            get
            {
                var initial = (char)Title.ToLower()[0];
                switch (initial)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                        return "A-F";
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                        return "G-K";
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                        return "L-P";
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                        return "Q-U";
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        return "V-Z";
                    default:
                        return "Other";
                }
            }
        }
    }
}

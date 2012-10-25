﻿using Spakll.CodeMash.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spakll.CodeMash.ViewModel.Sessions
{
    public class GroupView : NavigableItem
    {
        public GroupView()
        {
            Technologies = new List<TechnologyView>();
        }

        public IList<TechnologyView> Technologies { get; private set; }
    }
}

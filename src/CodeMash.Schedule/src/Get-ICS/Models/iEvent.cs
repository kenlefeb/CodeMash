using System;

namespace Get_ICS.Models
{
    internal class iEvent
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Location { get; set; }
    }
}
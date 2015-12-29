using System.Collections.Generic;

namespace Get_ICS.Models
{
    internal class iCalendar
    {
        public List<iEvent> Events { get; set; } = new List<iEvent>();
        public string ProductId { get; set; }
        public string Version { get; set; }

    }
}
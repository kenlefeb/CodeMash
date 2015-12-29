using System;

namespace Get_ICS.Models
{
    public class PublicSessionDataModel
    {
        public string Abstract { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
        public string[] Rooms { get; set; }
        public DateTime SessionEndTime { get; set; }
        public DateTime SessionStartTime { get; set; }
        public string SessionType { get; set; }
        public PublicSpeakerThinDataModel[] Speakers { get; set; }
        public string[] Tags { get; set; }
        public string Title { get; set; }
    }
}
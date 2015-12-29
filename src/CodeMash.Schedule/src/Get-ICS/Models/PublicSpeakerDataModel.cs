using System;

namespace Get_ICS.Models
{
    public class PublicSpeakerDataModel : PublicSpeakerThinDataModel
    {
        public string Biography { get; set; }
        public string BlogUrl { get; set; }
        public string GitHubLink { get; set; }
        public string LinkedInProfile { get; set; }
        public string TwitterLink { get; set; }
    }

    public class PublicSpeakerThinDataModel
    {
        public string FirstName { get; set; }
        public string GravatarUrl { get; set; }
        public Guid Id { get; set; }
        public string LastName { get; set; }
    }
}
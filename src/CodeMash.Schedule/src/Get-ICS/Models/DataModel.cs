using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace Get_ICS.Models
{
    public class DataModel
    {
        public DataModel(Uri baseUri)
        {
            var client = new RestClient
            {
                BaseUrl = baseUri
            };
            var speakersResponse = client.Get(new RestRequest("SpeakersData?type=json"));
            if (speakersResponse.StatusCode == HttpStatusCode.OK)
            {
                Speakers = JsonConvert.DeserializeObject<PublicSpeakerDataModel[]>(speakersResponse.Content);
            }
            var sessionsResponse = client.Get(new RestRequest("SessionsData?type=json"));
            if (sessionsResponse.StatusCode == HttpStatusCode.OK)
            {
                Sessions = JsonConvert.DeserializeObject<PublicSessionDataModel[]>(sessionsResponse.Content);
                foreach (var session in Sessions)
                {
                    session.Speakers = session.Speakers.Select(speaker => Speakers.FirstOrDefault(s => s.Id == speaker.Id)).Where(speakerRef => speakerRef != null).ToArray();
                }
            }
        }

        public PublicSessionDataModel[] Sessions { get; set; }
        public PublicSpeakerDataModel[] Speakers { get; set; }
    }
}
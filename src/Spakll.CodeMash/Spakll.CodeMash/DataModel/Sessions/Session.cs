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
using Spakll.CodeMash.Common;

namespace Spakll.CodeMash.Data
{
    /// <summary>
    /// Generic item data model.
    /// </summary>
    public class Session : BindableBase
    {
        /*
         * 
	        {
		        "Title":			".NET TDD Immersion (Tuesday Half Day PM)",
		        "Abstract":			"TDD Immersion covers everything you need to know to do test-driven development on real .NET projects. We'll go over stuff like how to write tests first, how to refactor your code to make it easier to test, mocking frameworks like Moq, dependency injection with StructureMap, and other TDD tips and tricks I've learned from doing TDD over the years.\r\n\r\nWe'll also walk through a sample ASP.NET MVC web app and show you how you might set up an actual project, work with ORMs and data access layers, set up your test projects, and make things easy to test.  We'll end with some TDD practice to help you hone your TDD skills, so bring your laptop (or pair up with someone who has one). TDD has revolutionized the way that I write code and it can do the same for you! \r\n",
		        "Start":			"2013-01-08T21:30:00Z",
		        "Difficulty":		"Intermediate",
		        "SpeakerName":		"Jon Kruger",
		        "Technology":		".NET",
		        "URI":				"/api/sessions.json/NET-TDD-Immersion-Tuesday-Half-Day-PM",
		        "EventType":		"PreCompiler",
		        "SessionLookupId":	"NET-TDD-Immersion-Tuesday-Half-Day-PM",
		        "SpeakerURI":		"/api/speakers.json/Jon-Kruger"
	        }
         * 
         */
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private string _abstract;
        public string Abstract
        {
            get { return _abstract; }
            set { SetProperty(ref _abstract, value); }
        }

        private DateTime start;
        public DateTime Start
        {
            get { return start; }
            set { SetProperty(ref start, value); }
        }

        private string difficulty;
        public string Difficulty
        {
            get { return difficulty; }
            set { SetProperty(ref difficulty, value); }
        }

        private string speakerName;
        public string SpeakerName
        {
            get { return speakerName; }
            set { SetProperty(ref speakerName, value); }
        }

        private string technology;
        public string Technology
        {
            get { return technology; }
            set { SetProperty(ref technology, value); }
        }

        private string uri;
        public string URI
        {
            get { return uri; }
            set { SetProperty(ref uri, value); }
        }

        private string eventType;
        public string EventType
        {
            get { return eventType; }
            set { SetProperty(ref eventType, value); }
        }

        private string sessionLookupId;
        public string SessionLookupId
        {
            get { return sessionLookupId; }
            set { SetProperty(ref sessionLookupId, value); }
        }

        private string speakerURI;
        public string SpeakerURI
        {
            get { return speakerURI; }
            set { SetProperty(ref speakerURI, value); }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NDCOsloSpeakerList.Shared
{
    public class SpeakerList
    {
        public List<Speaker> Speakers { get; set; }

        public SpeakerList()
        {
            Speakers = new List<Speaker>();
            Speakers.Add(new Speaker()
            {
                SpeakerName = "Alex Dunn",
                SessionTitle = "Fluxing Up Your .NET Apps",
                SessionSummary = "Learn about the Flux design pattern and how to implement it in your C# client applications like UWP, Xamarin, and all the other platforms .NET is touching now.",
                SpeakerImage = "./Assets/SpeakerImages/Dunn.jpg"
            });
            Speakers.Add(new Speaker()
            {
                SpeakerName = "Heather Downing",
                SessionTitle = "The Care and Feeding of Software Engineers",
                SessionSummary = "After years of excellence as a developer who gets things done, you are rewarded with a leadership title and more responsibility.",
                SpeakerImage = "./Assets/SpeakerImages/Downing.jpg"
            });
            Speakers.Add(new Speaker()
            {
                SpeakerName = "Dylan Beattie",
                SessionTitle = "The Art of Code",
                SessionSummary = "Software and technology has changed every aspect of the world we live in. At one extreme are the ‘mission critical’ applications - the code that runs our banks, our hospitals, our airports and phone networks. Then there’s the code we all use every day to browse the web, watch movies, create spreadsheets… not quite so critical, but still code that solves problems and delivers services.",
                SpeakerImage = "./Assets/SpeakerImages/Beattie.png"
            });
            Speakers.Add(new Speaker()
            {
                SpeakerName = "Brandon Minnick",
                SessionTitle = "Choosing The Best Mobile Framework",
                SessionSummary = "Choosing a mobile app framework is overwhelming - there are dozens to evaluate. From native frameworks written in Swift, ObjC, Java, and Kotlin to cross-platform frameworks like React Native and Xamarin, it is difficult to understand the key differences between them.",
                SpeakerImage = "./Assets/SpeakerImages/Minnick.jpg"
            });

        }
    }
}
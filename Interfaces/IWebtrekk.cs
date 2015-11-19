using System;
using System.Collections.Generic;

namespace XamarinWebtrekkBindings.Interfaces
{
    public interface IWebtrekk
    {
        void InitWebtrekk();
        void ActivityStart(object activity);
        void ActivityStop(object activity);
        void TrackAction(string pageContent, string action, IDictionary<string, string> parameters);
        void TrackAction(string pageContent, string action);
        object TrackMedia(string s1, int num1, int num2, object mediaCategories);
        object TrackMedia(string s1, int num1, int num2);
        void TrackPage(string s1, IDictionary<string, string> dictionary);
        void TrackPage(string s1);

        string AppVersionParameter { set; }
        object Context{ get; set; }
        string EverId{ get; }
        Boolean LoggingEnabled{ get; set; }
        Boolean OptedOut{ get; set; }
        int SamplingRate{ get; set; }
        long SendDelay{ get; set; }
        string ServerUrl{ get; set; }
        string TrackId{ get; set; }
        string Version{ get; }
    }
}

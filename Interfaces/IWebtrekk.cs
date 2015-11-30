using System;
using System.Collections.Generic;

namespace XamarinWebtrekkBindings.Interfaces
{
    public interface IWebtrekk
    {
        void Init();
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
        int SamplingRate{ get; }
        long SendDelay{ get; }
        string ServerUrl{ get; }
        string TrackId{ get; }
        string Version{ get; }
        WebtrekkConfig Config { get; set; }
    }
}

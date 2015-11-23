using System;

namespace XamarinWebtrekkBindings
{
    public class WebtrekkConfig
    {
        public string AppVersionParameter { set; get; }
        public bool LoggingEnabled { set; get; }
        public int SamplingRate { set; get; } = 0;
        public long SendDelay { set; get; } = 300000;
        public string ServerUrl { set; get; }
        public string TrackId { set; get; }
    }
}

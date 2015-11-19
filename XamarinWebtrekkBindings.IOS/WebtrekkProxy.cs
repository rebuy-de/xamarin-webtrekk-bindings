using System;
using System.Collections.Generic;
using Foundation;
using IOS.Libraries;
using XamarinWebtrekkBindings.Interfaces;

namespace XamarinWebtrekkBindings
{
    public class WebtrekkProxy : IWebtrekk
    {
        private WTConfiguration wtConfiguration;
        private string serverUrl;
        private string trackId;

        public WebtrekkProxy()
        {
        }

        public void InitWebtrekk()
        {
            if (String.IsNullOrEmpty(serverUrl) || String.IsNullOrEmpty(trackId)) {
                throw new Exception("You have to setUp Webtrekk");
            }

            wtConfiguration = new WTConfiguration(new NSUrl(serverUrl), trackId);
            Webtrekk.StartWithConfiguration(wtConfiguration);
        }

        public void ActivityStart(object activity)
        {
        }

        public void ActivityStop(object activity)
        {
        }

        public void TrackAction(string pageContent, string action, IDictionary<string, string> parameters)
        {
            Webtrekk.TrackClick(pageContent, action, Converter.ConvertDictionaryToNSDictionary(parameters));
        }

        public void TrackAction(string pageContent, string action)
        {
            Webtrekk.TrackClick(pageContent, action);
        }

        public object TrackMedia(string s1, int num1, int num2, object mediaCategories)
        {
            throw new NotImplementedException();
        }

        public object TrackMedia(string s1, int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public void TrackPage(string s1, IDictionary<string, string> dictionary)
        {
            Webtrekk.TrackContent(s1, Converter.ConvertDictionaryToNSDictionary(dictionary));
        }

        public void TrackPage(string s1)
        {
            Webtrekk.TrackContent(s1);
        }

        public string AppVersionParameter {
            set {
                Webtrekk.SetAppVersionParameter(value);
            }
        }

        public object Context {
            get;
            set;
        }

        public string EverId {
            get {
                return Webtrekk.EverId();
            }
        }

        public bool LoggingEnabled {
            get;
            set;
        }

        public bool OptedOut {
            get {
                return Webtrekk.OptedOut;
            }
            set {
                Webtrekk.OptedOut = value;
            }
        }

        public int SamplingRate {
            get {
                if (wtConfiguration == null) {
                    throw new Exception("You have to setUp Webtrekk");
                }

                return Convert.ToInt32(wtConfiguration.SamplingRate);
            }
            set {
                wtConfiguration.SamplingRate = Convert.ToUInt32(value);
            }
        }

        public long SendDelay {
            get {
                return Convert.ToInt64(wtConfiguration.SendDelay);
            }
            set {
                wtConfiguration.SendDelay = (double) value;
            }
        }

        public string ServerUrl {
            get {
                return wtConfiguration.ServerUrl.AbsoluteString;
            }
            set {
                serverUrl = value;
            }
        }

        public string TrackId {
            get {
                return wtConfiguration.TrackId;
            }
            set {
                trackId = value;
            }
        }

        public string Version {
            get {
                return Webtrekk.Version();
            }
        }
    }
}


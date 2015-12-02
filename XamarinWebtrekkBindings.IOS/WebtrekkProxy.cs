using System;
using System.Collections.Generic;
using Foundation;
using IOS.Libraries;
using Xamarin.Forms;
using XamarinWebtrekkBindings;
using XamarinWebtrekkBindings.Interfaces;

namespace XamarinWebtrekkBindings
{
    public class WebtrekkProxy : IWebtrekk
    {
        private WTConfiguration wtConfiguration;

        public void Init()
        {
            if (String.IsNullOrEmpty(Config?.ServerUrl) || String.IsNullOrEmpty(Config?.TrackId)) {
                throw new Exception("You have to set at least serverUrl and trackId in the Config");
            }

            wtConfiguration = new WTConfiguration(new NSUrl(Config.ServerUrl), Config.TrackId);
            Webtrekk.StartWithConfiguration(wtConfiguration);

            wtConfiguration.SamplingRate = Convert.ToUInt32(Config.SamplingRate);
            wtConfiguration.SendDelay = Config.SendDelay;

            if (!String.IsNullOrEmpty(Config.AppVersionParameter)) {
                Webtrekk.SetAppVersionParameter(Config.AppVersionParameter);
            }
        }

        public void ActivityStart(object activity)
        {
        }

        public void ActivityStop(object activity)
        {
        }

        public void TrackAction(string pageContent, string action, IDictionary<string, string> parameters)
        {
            Webtrekk.TrackClick(action, pageContent, Converter.ConvertDictionaryToNSDictionary(parameters));
        }

        public void TrackAction(string pageContent, string action)
        {
            Webtrekk.TrackClick(action, pageContent);
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
                return Convert.ToInt32(wtConfiguration?.SamplingRate);
            }
        }

        public long SendDelay {
            get {
                return Convert.ToInt64(wtConfiguration?.SendDelay);
            }
        }

        public string ServerUrl {
            get {
                return wtConfiguration?.ServerUrl?.AbsoluteString;
            }
        }

        public string TrackId {
            get {
                return wtConfiguration?.TrackId;
            }
        }

        public string Version {
            get {
                return Webtrekk.Version();
            }
        }

        public WebtrekkConfig Config { set; get; }
    }
}


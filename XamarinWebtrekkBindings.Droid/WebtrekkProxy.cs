using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Com.Webtrekk.Android.Tracking;
using Xamarin.Forms;
using XamarinWebtrekkBindings;
using XamarinWebtrekkBindings.Interfaces;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace XamarinWebtrekkBindings
{
    public class WebtrekkProxy : IWebtrekk
    {
        public WebtrekkProxy()
        {
            Webtrekk.Context = Forms.Context;
        }

        public void InitWebtrekk()
        {
            if (String.IsNullOrEmpty(Config?.ServerUrl) || String.IsNullOrEmpty(Config?.TrackId)) {
                throw new Exception("You have to set at least serverUrl and trackId in the Config");
            }

            Webtrekk.ServerUrl = Config.ServerUrl;
            Webtrekk.TrackId = Config.TrackId;
            Webtrekk.SamplingRate = Config.SamplingRate;
            Webtrekk.SendDelay = Config.SendDelay;
            Webtrekk.LoggingEnabled = Config.LoggingEnabled;

            if (!String.IsNullOrEmpty(Config.AppVersionParameter)) {
                Webtrekk.SetAppVersionParameter(Config.AppVersionParameter);
            }

            Webtrekk.ActivityStart((Activity) Forms.Context);
        }

        public void ActivityStart(object activity)
        {
            if (activity.GetType() != typeof(Activity)) {
                throw new Exception("wrong type");
            }
            Webtrekk.ActivityStart((Activity)activity);
        }

        public void ActivityStop(object activity)
        {
            if (activity.GetType() != typeof(Activity)) {
                throw new Exception("wrong type");
            }
            Webtrekk.ActivityStop((Activity)activity);
        }

        public void TrackAction(string pageContent, string action, IDictionary<string, string> parameters)
        {
            Webtrekk.TrackAction(pageContent, action, parameters);
        }

        public void TrackAction(string pageContent, string action)
        {
            Webtrekk.TrackAction(pageContent, action);
        }

        public object TrackMedia(string s1, int num1, int num2, object mediaCategories)
        {
            if (mediaCategories.GetType() != typeof(MediaCategories)) {
                throw new Exception("wrong type");
            }
            return Webtrekk.TrackMedia(s1, num1, num2, (MediaCategories) mediaCategories);
        }

        public object TrackMedia(string s1, int num1, int num2)
        {
            return Webtrekk.TrackMedia(s1, num1, num2);
        }

        public void TrackPage(string s1, IDictionary<string, string> dictionary)
        {
            Webtrekk.TrackPage(s1, dictionary);
        }

        public void TrackPage(string s1)
        {
            Webtrekk.TrackPage(s1);
        }

        public string AppVersionParameter {
            set {
                Webtrekk.SetAppVersionParameter(value);
            }
        }

        public object Context {
            get {
                return Webtrekk.Context;
            }
            set {
                if (value.GetType() != typeof(Context)) {
                    throw new Exception("wrong type");
                }
                Webtrekk.Context = (Context) value;
            }
        }

        public string EverId {
            get {
                return Webtrekk.EverId;
            }
        }

        public bool LoggingEnabled {
            get {
                return Webtrekk.LoggingEnabled;
            }
            set {
                Webtrekk.LoggingEnabled = value;
            }
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
                return Webtrekk.SamplingRate;
            }
        }

        public long SendDelay {
            get {
                return Webtrekk.SendDelay;
            }
        }

        public string ServerUrl {
            get {
                return Webtrekk.ServerUrl;
            }
        }

        public string TrackId {
            get {
                return Webtrekk.TrackId;
            }
        }

        public string Version {
            get {
                return Webtrekk.Version;
            }
        }

        public WebtrekkConfig Config { get; set; }
    }
}


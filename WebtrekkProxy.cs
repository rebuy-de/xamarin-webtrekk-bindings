using System;
using System.Collections.Generic;
using XamarinWebtrekkBindings.Interfaces;

namespace XamarinWebtrekkBindings
{
    public class WebtrekkProxy : IWebtrekk
    {
        public WebtrekkProxy()
        {
            throw new NotImplementedException();
        }

        public void InitWebtrekk()
        {
            throw new NotImplementedException();
        }

        public void ActivityStart(object activity)
        {
            throw new NotImplementedException();
        }

        public void ActivityStop(object activity)
        {
            throw new NotImplementedException();
        }

        public void TrackAction(string pageContent, string action, IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public void TrackAction(string pageContent, string action)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void TrackPage(string s1)
        {
            throw new NotImplementedException();
        }

        public string AppVersionParameter {
            set {
                throw new NotImplementedException();
            }
        }

        public object Context {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string EverId {
            get {
                throw new NotImplementedException();
            }
        }

        public bool LoggingEnabled {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public bool OptedOut {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public int SamplingRate {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public long SendDelay {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string ServerUrl {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string TrackId {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string Version {
            get {
                throw new NotImplementedException();
            }
        }

        public WebtrekkConfig Config {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }
    }
}


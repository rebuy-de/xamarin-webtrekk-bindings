using System;
using System.Collections.Generic;
using WebtrekkSample.Pages;
using Xamarin.Forms;
using XamarinWebtrekkBindings;

namespace WebtrekkSample
{
    public class App : Application
    {
        public App()
        {
            var webtrekk = Webtrekk.Instance;
            webtrekk.Config = new WebtrekkConfig {
                AppVersionParameter = "cs2",
                SamplingRate = 0,
                SendDelay = 10000,
                ServerUrl = "https://q3.webtrekk.net",
                TrackId = "111111111111111"
            };

            webtrekk.Init();
            webtrekk.LoggingEnabled = true;
            webtrekk.TrackAction("init", "appStart");

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}


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
            var test = new WebtrekkProxy {
                ServerUrl = "https://webtrekkServer.net",
                TrackId = "1784",
                AppVersionParameter = "cs2"
            };
            test.InitWebtrekk();
            test.SamplingRate = 0;
            test.SendDelay = 300000;
            test.LoggingEnabled = true;
            test.TrackAction("init", "appStart");
            test.TrackPage("Seite1", new Dictionary<string, string> {
                {"test", "was"},
                {"zwei", "wert"}
            });
            // The root page of your application
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


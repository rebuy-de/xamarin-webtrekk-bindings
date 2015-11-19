using System;
using System.Collections.Generic;
using WebtrekkSample.Pages;
using Xamarin.Forms;

namespace WebtrekkSample
{
    public class App : Application
    {
        public App()
        {
            var webtrekk = Webtrekk.Instance.GetWebtrekkProxy();
            webtrekk.ServerUrl = "https://q3.webtrekk.net";
            webtrekk.TrackId = "111111111111111";
            webtrekk.AppVersionParameter = "cs2";

            webtrekk.InitWebtrekk();
            webtrekk.SamplingRate = 0;
            webtrekk.SendDelay = 300000;
            webtrekk.LoggingEnabled = true;
            webtrekk.TrackAction("init", "appStart");
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


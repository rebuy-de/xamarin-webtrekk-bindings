using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using WebtrekkBindings;

namespace WebtrekkSample.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init ();

            // Code for starting up the Xamarin Test Cloud Agent
            #if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
            #endif

            LoadApplication (new App ());

            var test = new WebtrekkProxy {
                ServerUrl = "https://rebuy01.webtrekk.net",
                TrackId = "1234",
                AppVersionParameter = "cs5"
            };
            test.InitActivity();
            test.TrackAction("init", "appStart");
            test.TrackPage("Seite1", new Dictionary<string, string> {
                {"test", "was"},
                {"zwei", "wert"}
            });

            return base.FinishedLaunching (app, options);
        }
    }
}


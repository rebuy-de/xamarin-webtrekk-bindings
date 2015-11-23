using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WebtrekkSample.Pages
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            Webtrekk.Instance.TrackPage("Seite2", new Dictionary<string, string> {
                {"st", "view"},
                {"co", "102.34"}
            });
        }
    }
}

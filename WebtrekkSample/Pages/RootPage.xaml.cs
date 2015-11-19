using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebtrekkSample.Pages
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, true);
        }

        private void goToNextPage(Object sender, EventArgs e)
        {
            Webtrekk.Instance.GetWebtrekkProxy().TrackPage("Seite1", new Dictionary<string, string> {
                {"st", "view"},
                {"co", "99.34"}
            });
            Navigation.PushAsync(new SecondPage());
        }
    }
}

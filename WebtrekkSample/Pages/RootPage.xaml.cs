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

            Webtrekk.Instance.TrackPage("Seite1", new Dictionary<string, string> {
                {"st", "view"},
                {"co", "99.34"}
            });
        }

        private void goToNextPage(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}

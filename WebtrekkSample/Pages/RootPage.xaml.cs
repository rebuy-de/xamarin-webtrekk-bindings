using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using WebtrekkBindings;

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
//            new WebtrekkProxy().TrackPage("SecondPageOpened");
            Navigation.PushAsync(new SecondPage());
        }
    }
}

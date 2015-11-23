using System;
using Xamarin.Forms;

namespace WebtrekkSample.Pages
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void goToSecondPage(Object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new SecondPage());
            IsPresented = false;
        }

        private void goToMainPage(Object sender, EventArgs e)
        {
            Detail.Navigation.PopToRootAsync();
            IsPresented = false;
        }
    }
}

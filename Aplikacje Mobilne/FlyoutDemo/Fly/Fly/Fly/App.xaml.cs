using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyoutDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppFlyoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

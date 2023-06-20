using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureLab09
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }

        public static double ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

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

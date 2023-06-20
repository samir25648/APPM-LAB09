using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureLab09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SwipeDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TapDemo());
            };

        }
    }
}
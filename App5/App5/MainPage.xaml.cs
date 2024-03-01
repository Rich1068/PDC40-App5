using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Activity1Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }
        public async void Activity2Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }
        public async void Activity3Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }
        public async void Activity4Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity4());
        }
        public async void Activity5Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity5());
        }
    }
}

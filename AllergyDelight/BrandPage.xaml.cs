using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllergyDelight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrandPage : ContentPage
    {
        public BrandPage()
        {
            InitializeComponent();
        }

        private async void McDonalds_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Subway_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubwayMainPage());
        }

        private async void Supermacs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupermacsMainPage());
        }
    }
}
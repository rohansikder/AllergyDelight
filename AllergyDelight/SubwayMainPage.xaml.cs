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
    public partial class SubwayMainPage : ContentPage
    {
        public SubwayMainPage()
        {
            InitializeComponent();
        }

        private async void filter_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubwayFilterPage());
        }

        private async void restaurants_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subway());
        }
        private async void brand_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrandPage());
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AllergyDelight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }


        private async void filter_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }

        //Sends User to Resturants Page
        private async void restaurants_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void tools_clicked(object sender, EventArgs e)
        {

        }


    }
}

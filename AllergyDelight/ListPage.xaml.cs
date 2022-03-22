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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

        }

        private async void filter_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }


        //Sends User to Resturants Page
        private async void menu_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void tools_clicked(object sender, EventArgs e)
        {

        }


        private async void mcdoanlds1_clicked(object sender, EventArgs e)
        {

        }

        private async void mcdoanlds2_clicked(object sender, EventArgs e)
        {

        }

        private async void supermacs1_clicked(object sender, EventArgs e)
        {

        }

        private async void subway1_clicked(object sender, EventArgs e)
        {

        }
    }
}



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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        //Send user to HomePage
        async private void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
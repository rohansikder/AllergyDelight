﻿using System;
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

        private async void mcdoanlds1_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void supermacs1_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Supermacs());
        }

        private async void subway1_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subway());
        }
    }
}
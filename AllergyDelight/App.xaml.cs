﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllergyDelight
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Used to navigate from One page to another
            MainPage = new NavigationPage(new BrandPage());
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

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
    public partial class SupermacsMainPage : ContentPage
    {
        Label[] menuFoodLabels = new Label[5];





        string[] foodNames =
       {
          "Mighty Mac",
          "Taco Fries",
          "Vegan Sub Sandwich",
          "Chicken Breast Sandwich",
          "Chocolate Muffin & Ice Cream",
        };









    

        private void CreateMenu2()
        {
            int row = 0;
            const int ROW_MULTIPLIER = 1; //Do not change value as its used to fix the layout of menu

            for (int count = 0; count < menuFoodLabels.Length; count++)
            {
                menuFoodLabels[count] = new Label();
                menuFoodLabels[count].SetValue(Grid.RowProperty, row + ROW_MULTIPLIER);
                menuFoodLabels[count].SetValue(Grid.ColumnProperty, 0);
                menuFoodLabels[count].Text = foodNames[count];
                menuFoodLabels[count].HorizontalTextAlignment = TextAlignment.Center;
                menuFoodLabels[count].VerticalTextAlignment = TextAlignment.Center;
                menuFoodLabels[count].TextColor = Color.Black;
                menuFoodLabels[count].Padding = new Thickness(5, 0, 0, 0);
                menuFoodLabels[count].FontSize = Device.GetNamedSize(NamedSize.Small, menuFoodLabels[count]);
                menuFoodLabels[count].HorizontalOptions = LayoutOptions.Center;
                GrdMenuArea.Children.Add(menuFoodLabels[count]);
                row++;
            }
        }
        public SupermacsMainPage()
        {
            InitializeComponent();
            CreateMenu2();
        }

        private async void filter_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupermacsFilterPage());
        }

        private async void restaurants_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Supermacs());
        }
        private async void brand_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrandPage());
        }
    }
}
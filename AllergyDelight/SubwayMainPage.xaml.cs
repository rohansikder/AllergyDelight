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

        Label[] menuFoodLabels = new Label[5];
        string[] ingredientNames =
           {
            "Wheat",
            "Rye",
            "Barley",
            "Oats",
            "Spelt",
            "Kamut",
            "Soya",
            "Nuts",
            "Peanuts",
            "Sesame",
            "Milk",
            "Eggs",
            "Fish",
            "Crustaceans",
            "Celery",
            "Sulphur Dioxide And Sulphites",
            "Mustard",
            "Molluscs",
            "Lupin",
            "Gluten"
            };

        string[] foodNames =
       {
          "Italian B.M.T Sub",
          "Egg & Cheese Sub",
          "Veggie Delite Sub",
          "Hash Browns",
          "Cookies",
        };


        public SubwayMainPage()
        {
            InitializeComponent();
            CreateMenu1();
        }

        public SubwayMainPage(string ingredientToCheck)
        {
            InitializeComponent();
            CreateMenu1();
            CheckMenu(ingredientToCheck);
        }

        private void CreateMenu1()
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

        private void CheckMenu(string ingredientToCheck) 
        {
            int ItalianBMTSub= 1;
            int EggAndCheeseSub = 2;
            int VeggieDelightSub = 3;
            int hasBrowns = 4;
            int cookies = 5;

            if (ingredientToCheck == ingredientNames[19]) //if gluten
            {
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (menuFoodLabels[count] != menuFoodLabels[1])
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }
                }
            }

        }

        private void DisableStickers(int food)
        {

            if (food == 1)
            {
                
            }
            else if (food == 2)
            {
              
            }
            else if (food == 3)
            {
               
            }
            else if (food == 4)
            {
                

            }
            else if (food == 5)
            {
                
            }

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
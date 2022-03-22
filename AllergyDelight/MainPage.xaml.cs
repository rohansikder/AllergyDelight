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
            };
        string[] foodNames = 
        {
          "BigMac",
          "McPlant", 
          "The Spicy Veggie One", 
          "Bacon and Egg McMuffin", 
          "Oreo McFlurry", 
        };
        public MainPage()
        {
            InitializeComponent();
            CreateMenu();
        }

        public MainPage(string ingredientToCheck)//need change
        {
            InitializeComponent();
            CreateMenu();
            CheckMenu(ingredientToCheck);
        }

        private void CheckMenu(string ingredientToCheck)
        {
            if (ingredientToCheck == ingredientNames[0]
                || ingredientToCheck == ingredientNames[10])//if the ingredient is wheat or milk
            {
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    menuFoodLabels[count].IsVisible = false;
                }

                Vegan1.IsVisible = false;
                Vegan2.IsVisible = false;
                Vegetarian1.IsVisible = false;
                MenuTitle.FontSize = Device.GetNamedSize(NamedSize.Small, MenuTitle);
                MenuTitle.Text = "There is nothing on the menu. Please go back..";
            }
            else if (ingredientToCheck == ingredientNames[6]) //if ingred is soya
            {
                //MCflurry
                menuFoodLabels[4].IsVisible = false;
                Vegetarian1.IsVisible = false;

            } else if (ingredientToCheck == ingredientNames[2])  //if ingred is Barley
            {
                
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (count != 3) //if the current food is not bacon and egg
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }
                    
                }
                Vegan1.IsVisible = false;
                Vegan2.IsVisible = false;
                Vegetarian1.IsVisible = false;
            }
            else if (ingredientToCheck == ingredientNames[3]) //if ingred is oats
            {
                menuFoodLabels[4].IsVisible = false;
                Vegetarian1.IsVisible = false;
            }
            else if (ingredientToCheck == ingredientNames[1]) //if ingred is rye
            {
              
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (count != 4) //if the current food is not flurryOreo
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }

                }

                Vegan1.IsVisible = false;
                Vegan2.IsVisible = false;
            }
            else if (ingredientToCheck == ingredientNames[11]) //if ingred is eggs
            {
                //For bacon and big mac
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (count == 0 || count == 3) 
                    {
                        menuFoodLabels[count].IsVisible = true;
                    }
                    else
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }

                    Vegan1.IsVisible = false;
                    Vegan2.IsVisible = false;
                    Vegetarian1.IsVisible = false;

                }
            }
            else if (ingredientToCheck == ingredientNames[9]) //if ingred is sesame
            {
                
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (count != 4) 
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }

                }

                Vegan1.IsVisible = false;
                Vegan2.IsVisible = false;
            }
            else if (ingredientToCheck == ingredientNames[16]) //if ingred is mustard
            {
                for (int count = 0; count < menuFoodLabels.Length; count++)
                {
                    if (count == 0 || count == 1 || count == 2) //if its bigmac, mcplant, spicy veggie
                    {
                        menuFoodLabels[count].IsVisible = false;
                    }
                    else
                    {
                        menuFoodLabels[count].IsVisible = true;
                    }

                }

                Vegan1.IsVisible = false;
                Vegan2.IsVisible = false;
            }
        }

        private void CreateMenu()
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

        private async void filter_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }

        //Sends User to Resturants Page
        private async void restaurants_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }
        private async void tools_clicked(object sender, EventArgs e)
        {
            
        }


    }
}

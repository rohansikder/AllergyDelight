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
    public partial class FilterPage : ContentPage
    {
        //Global variables
        CheckBox[] checkBoxes = new CheckBox[19];
        Label[] ingredientLabels = new Label[19];
        string ingredientToCheck;
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
       

        //struct Food
        //{
        //    public bool wheat;
        //    public bool rye;
        //    public bool barley;
        //    public bool oats;
        //    public bool spelt;
        //    public bool kamut;
        //    public bool soya;
        //    public bool nuts;
        //    public bool peanuts;
        //    public bool sesame;
        //    public bool milk;
        //    public bool eggs;
        //    public bool fish;
        //    public bool crustaceans;
        //    public bool celery;
        //    public bool sulphurDioxideAndSulphites;
        //    public bool mustard;
        //    public bool molluscs;
        //    public bool lupin;
        //}

        public FilterPage()
        {
            InitializeComponent();
            InitilisePage();
        }

        private void InitilisePage()
        {
            CreateCheckboxes();
            CreateFoodLbls();
        }


        private void CreateFoodLbls()
        {
            for (int row = 0; row < 19; row++)
            {
                ingredientLabels[row] = new Label();
                ingredientLabels[row].SetValue(Grid.RowProperty, row);
                ingredientLabels[row].SetValue(Grid.ColumnProperty, 0);
                ingredientLabels[row].Text = ingredientNames[row];
                ingredientLabels[row].FontSize = Device.GetNamedSize(NamedSize.Small, ingredientLabels[row]);
                ingredientLabels[row].HorizontalOptions = LayoutOptions.Center;
                ingredientLabels[row].BackgroundColor = Color.Orange;
                ingredientLabels[row].WidthRequest = 300;
                GrdFilterPage.Children.Add(ingredientLabels[row]);
            }
        }

        private void CreateCheckboxes()
        {
            for (int row = 0; row < 19; row++)
            {
                checkBoxes[row] = new CheckBox();
                checkBoxes[row].SetValue(Grid.RowProperty, row);
                checkBoxes[row].SetValue(Grid.ColumnProperty, 1);
                checkBoxes[row].Color = Color.Blue;
                checkBoxes[row].IsChecked = false;
                checkBoxes[row].CheckedChanged += OnCheckBoxCheckedChanged;
                GrdFilterPage.Children.Add(checkBoxes[row]);
            }
        }

        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
            CheckBox curCheckBox = (CheckBox)sender;
            int curRow = (int)curCheckBox.GetValue(Grid.RowProperty);

            if (curCheckBox.IsChecked == true)
            {
                for (int count = 0; count < checkBoxes.Length; count++)
                {
                    if (count != curRow)
                    {
                        checkBoxes[count].IsEnabled = false;
                        checkBoxes[count].IsVisible = false;
                        ingredientLabels[count].IsVisible = false;
                    }
                    
                }
            }
            else
            {
                for (int count = 0; count < checkBoxes.Length; count++)
                {
                    checkBoxes[count].IsEnabled = true;
                    checkBoxes[count].IsVisible = true;
                    ingredientLabels[count].IsVisible = true;
                }
               
            }
           
            CheckForFood(curRow);

        }

        private void CheckForFood(int curRow)
        {
            ingredientToCheck = ingredientNames[curRow];
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }


        //private void BtnSelectAll_Clicked(object sender, EventArgs e)
        //{
        //    for (int row = 0; row < checkBoxes.Length; row++)
        //    {
        //        checkBoxes[row].IsChecked = true;
        //    }
        //}

        private void BtnDeselectAll_Clicked(object sender, EventArgs e)
        {
            for (int row = 0; row < checkBoxes.Length; row++)
            {
                checkBoxes[row].IsChecked = false;
            }
        }

      
        private async void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(ingredientToCheck));//need something here
           
        }
    }
}
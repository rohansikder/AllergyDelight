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
    public partial class SubwayFilterPage : ContentPage
    {
        //Global variables
        RadioButton[] radioButtons = new RadioButton[20];
        //CheckBox[] checkBoxes = new CheckBox[19];
        Label[] ingredientLabels = new Label[20];
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
            "Gluten",
            };


        public SubwayFilterPage()
        {
            InitializeComponent();
            InitilisePage();
        }

        private void InitilisePage()
        {
            CreateRadioButtons();
            CreateFoodLbls();
        }

        private void CreateRadioButtons()
        {
            for (int row = 0; row < 20; row++)
            {
                radioButtons[row] = new RadioButton();
                radioButtons[row].SetValue(Grid.RowProperty, row);
                radioButtons[row].SetValue(Grid.ColumnProperty, 1);
                radioButtons[row].IsChecked = false;
                radioButtons[row].CheckedChanged += OnRadioButtonChecked;
                GrdSubwayFilterPage.Children.Add(radioButtons[row]);
            }
        }

        private void CreateFoodLbls()
        {
            for (int row = 0; row < 20; row++)
            {
                ingredientLabels[row] = new Label();
                ingredientLabels[row].SetValue(Grid.RowProperty, row);
                ingredientLabels[row].SetValue(Grid.ColumnProperty, 0);
                ingredientLabels[row].Text = ingredientNames[row];
                ingredientLabels[row].HorizontalTextAlignment = TextAlignment.Center;
                ingredientLabels[row].VerticalTextAlignment = TextAlignment.Center;
                ingredientLabels[row].FontSize = Device.GetNamedSize(NamedSize.Small, ingredientLabels[row]);
                ingredientLabels[row].HorizontalOptions = LayoutOptions.Center;
                ingredientLabels[row].BackgroundColor = Color.DodgerBlue;
                ingredientLabels[row].WidthRequest = 300;
                GrdSubwayFilterPage.Children.Add(ingredientLabels[row]);
            }
        }


        void OnRadioButtonChecked(object sender, CheckedChangedEventArgs e)
        {

            RadioButton curRadioButton = (RadioButton)sender;
            int curRow = (int)curRadioButton.GetValue(Grid.RowProperty);

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

        private async void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubwayMainPage(ingredientToCheck));//need something here

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopUpApp
{
    public partial class MainPage : ContentPage
    {
        private int score;
        public MainPage()
        {
            InitializeComponent();
            score = 0;
        }

        private async void InfoButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informacje o aplikacji", "Aplikacja jest, co jesteś taki dociekliwy.","Ok");
        }

        private async void CheckIfMoron_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Pytanie", "Czy lubisz programowanie?", "Tak", "Nie");

            if (answer)
                moronLable.Text = "To dobrze";
            else
                moronLable.Text = "To źle";
        }

        private async void FavLanguageButton_Clicked(object sender, EventArgs e)
        {
            string favLang = await DisplayActionSheet("Wybierz język: ", "Cancel", null, "C#", "Java", "Python");
            
            if(favLang != "Cancel")
                languageLable.Text = favLang;
        
        }

        private async void GameButton_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);

            var result = await DisplayPromptAsync("Pytanie", $"Ile jest {num1} + {num2}?","Zatwierdź","Anuluj", keyboard: Keyboard.Numeric);

            if(result==null)
                return;

            int.TryParse(result, out int tmp);
            if ((num1 + num2) == tmp)
                score++;


            scoreLable.Text = $"Punkty: {score}";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayPromptAsync("Pytanie", $"Podaj rok:", "Zatwierdź", "Anuluj", keyboard: Keyboard.Numeric);

            if (result == null)
                return;
            
            int.TryParse(result, out int yearToCheck);
            int currentYear = DateTime.Today.Year;

            if (yearToCheck <= 0 || yearToCheck > currentYear)
            {
                await DisplayAlert("Error", $"Możesz wpisać rok z zakresu 1 do {currentYear}", "OK");
                return;
            }

            if(yearToCheck % 4 == 0)
            {
                await DisplayAlert("", $"Rok jest przestępny", "OK");
            }
            else
            {
                await DisplayAlert("", $"Rok nie jest przestępny", "OK");
            }



        }
    }
}

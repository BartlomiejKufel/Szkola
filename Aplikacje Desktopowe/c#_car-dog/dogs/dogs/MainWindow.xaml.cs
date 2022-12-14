using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool status = false;
        private Person bartek = new("Bartek", 200, 0, 0);
        private Person janek = new("Janek", 200, 0, 0);
        private Person antek = new("Antek", 200, 0, 0);
        public MainWindow()
        {
            InitializeComponent();
            janekRadio.Content = $"{janek.Name} ma {janek.Money} zł";
            bartekRadio.Content=$"{bartek.Name} ma {bartek.Money} zł";
            antekRadio.Content=$"{antek.Name} ma {antek.Money} zł";

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radio = (RadioButton)sender;
            var name = radio.Content.ToString();
            switch (name[0].ToString())
            {
                case "B": personLable.Text = "Bartek";break;
                case "J": personLable.Text = "Janek";break;
                case "A": personLable.Text = "Antek";break;

                default:
                    break;
            }

            submitButton.IsEnabled = true;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string person = personLable.Text;
            if (!status)
            {
                switch (person)
                {
                    case "Bartek": bartekTextBox.Text = "Bartek nie zawarł zakładu"; break;
                    case "Janek": janekTextBox.Text = "Janek nie zawarł zakładu"; break;
                    case "Antek": antekTextBox.Text = "Antek nie zawarł zakładu"; break;
                    default:
                        break;
                }
            }
            else
            {
                switch (person)
                {
                    case "Bartek": bartek.Bet = (int)betInput.Value; bartek.DogNumber = (int)dogNumberInput.Value;
                        bartekTextBox.Text = $"{bartek.Name} stawia {bartek.Bet} zł na charta numer {bartek.DogNumber}";
                        break;
                    case "Janek": janek.Bet = (int)betInput.Value; janek.DogNumber = (int)dogNumberInput.Value;
                        janekTextBox.Text = $"{janek.Name} stawia {janek.Bet} zł na charta numer {janek.DogNumber}";
                        break;
                    case "Antek": antek.Bet = (int)betInput.Value; antek.DogNumber = (int)dogNumberInput.Value;
                        antekTextBox.Text = $"{antek.Name} stawia {antek.Bet} zł na charta numer {antek.DogNumber}";
                        break;
                    default:
                        break;
                }
            }

            if(janekTextBox.Text != "" && bartekTextBox.Text != "" && antekTextBox.Text != "")
            {
                gameButton.IsEnabled = true;
            }
        }

        private void ButtonStatus_Click(object sender, RoutedEventArgs e)
        {
            var sen = (Button)sender;
            if (status)
            {
                sen.Content = "nie stawia";
                dogNumberInput.IsEnabled = false;
                betInput.IsEnabled = false;
                status = false;
            }
            else
            {
                sen.Content = "stawia";
                dogNumberInput.IsEnabled = true;
                betInput.IsEnabled = true;
                status = true;
            }
        }

        private void GAME_START(object sender, RoutedEventArgs e)
        {
            Random rnd = new();
        
            int dog1=0, dog2=0, dog3=0, dog4 = 0;

            for (int i = 0; i < 10; i++)
            {
                dog1 = rnd.Next(1,100);
                dog2 = rnd.Next(1,100);
                dog3 = rnd.Next(1,100);
                dog4 = rnd.Next(1,100);
            }


            if(dog1 > dog2 && dog1 > dog3 && dog1 > dog4)
            {
                bartek.CheckWin(1);
                janek.CheckWin(1);
                antek.CheckWin(1);
            }
            else if( dog2 > dog1 && dog2 > dog3 && dog2 > dog4)
            {
                bartek.CheckWin(2);
                janek.CheckWin(2);
                antek.CheckWin(2);
            }
            else if( dog3 > dog1 && dog3 > dog2 && dog3 > dog4)
            {
                bartek.CheckWin(3);
                janek.CheckWin(3);
                antek.CheckWin(3);
            }
            else if( dog4 > dog1 && dog4 > dog2 && dog4 > dog3)
            {
                bartek.CheckWin(4);
                janek.CheckWin(4);
                antek.CheckWin(4);
            }


            janekRadio.Content = $"{janek.Name} ma {janek.Money} zł";
            bartekRadio.Content = $"{bartek.Name} ma {bartek.Money} zł";
            antekRadio.Content = $"{antek.Name} ma {antek.Money} zł";

            bartekTextBox.Text = "";
            janekTextBox.Text = "";
            antekTextBox.Text = "";

            gameButton.IsEnabled= false;
        }
    }
}

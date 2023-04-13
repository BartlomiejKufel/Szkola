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
using System.IO;

namespace RSPGame
{
    /// <summary>
    /// Logika interakcji dla klasy GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        string choice = "";
        public GamePage()
        {
            InitializeComponent();
        }

        private void Pick_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            choice = button.Name;


            if(choice == "scissorsButton")
            {
                paperButton.BorderBrush = Brushes.Transparent;
                rockButton.BorderBrush= Brushes.Transparent;
            }
            else if(choice == "rockButton")
            {
                paperButton.BorderBrush = Brushes.Transparent;
                scissorsButton.BorderBrush= Brushes.Transparent;
            }
            else if(choice == "paperButton")
            {
                rockButton.BorderBrush = Brushes.Transparent;
                scissorsButton.BorderBrush = Brushes.Transparent;
            }

            button.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#26bf3d");
            gameStartButton.IsEnabled = true;
        }

        private async void GameStart_Click(object sender, RoutedEventArgs e)
        {
            botStackPanel.Visibility = Visibility.Collapsed;
            Animation();
            await Task.Delay(3500);

            Random rnd = new Random();

            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;


            int los = rnd.Next(1,4);
                botStackPanel.Visibility = Visibility.Visible;
            if (los == 1)
            {
                botImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(path, @"\images\rock.png"), UriKind.Relative));
            }
            else if (los == 2)
            {
                botImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(path, @"\images\paper.png"), UriKind.Relative));
            }
            else if (los == 3)
            {
                botImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(path, @"\images\scissors.png"), UriKind.Relative));
            }

            MessageBox.Show(CheckForWin(los));

        }


        private async void Animation()
        {
            animationStackPanel.Visibility = Visibility.Visible;
            dotsTextBlock.Text = ".";
            for (int i = 0; i < 8; i++)
            {

                if (dotsTextBlock.Text == ". . .")
                {
                    dotsTextBlock.Text = ".";
                    await Task.Delay(300);
                }

                dotsTextBlock.Text += " .";
                await Task.Delay(300);
            }

            animationStackPanel.Visibility = Visibility.Collapsed;
        }

        //1-kamień
        //2-papier
        //3-nożyczki
        
        private string CheckForWin(int los)
        {
            switch (los)
            {
                case 1:
                    if (choice == "scissorsButton")
                    {
                        return "Przegrałeś";
                    }
                    else if (choice == "rockButton")
                    {
                        return "Remis";
                    }
                    else if (choice == "paperButton")
                    {
                        return "Wygrałeś";
                    }
                    break;

                case 2:
                    if (choice == "scissorsButton")
                    {
                        return "Wygrałeś";
                    }
                    else if (choice == "rockButton")
                    {
                        return "Przegrałeś";
                    }
                    else if (choice == "paperButton")
                    {
                        return "Remis";
                    }
                    break;

                case 3:
                    if (choice == "scissorsButton")
                    {
                        return "Remis";
                    }
                    else if (choice == "rockButton")
                    {
                        return "Wygrałeś";
                    }
                    else if (choice == "paperButton")
                    {
                        return "Przegrałeś";
                    }
                    break;

                default:
                    break;
            }

            return "lose";
        }
    }
}

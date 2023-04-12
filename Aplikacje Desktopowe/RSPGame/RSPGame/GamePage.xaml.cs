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

            button.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#26bf3d"); ;
        }
    }
}

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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user1 = new User(100);
        User user2 = new User(150);
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            portfel1TextBlock.Text = $"Portfel: {user1.Portfel} zł";
            portfel2TextBlock.Text = $"Portfel: {user2.Portfel} zł";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(req1TextBox.Text, out double bet);


            if (bet <= 0)
                MessageBox.Show("Błąd, podaj poprawną wartość", "Użytkownik 1");
            else if (bet > user1.Portfel)
                MessageBox.Show($"Nie masz wystarczających środków, aby postawić {bet} zł", "Użytkownik 1");
            else
            {
                var chance = rnd.NextDouble();

                if (chance >= 0.75)
                {
                    MessageBox.Show($"Gratulację wygrałeś {bet*2} zł", "Użytkownik 1");
                    user1.Portfel += (bet * 2);
                }
                else
                {
                    MessageBox.Show("Niestety, przegrałeś", "Użytkownik 1");
                    user1.Portfel -= bet;
                }

            }

            if (user1.Portfel <= 0)
            {
                req1TextBox.Text = "";
                req1TextBox.IsEnabled = false;
                var sen = sender as Button;
                sen.IsEnabled = false;
                portfel1TextBlock.Text = $"Portfel: jesteś spłukany";
            }
            else
                portfel1TextBlock.Text = $"Portfel: {user1.Portfel} zł";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double.TryParse(req2TextBox.Text, out double bet);


            if (bet <= 0)
                MessageBox.Show("Błąd, podaj poprawną wartość", "Użytkownik 2");
            else if (bet > user2.Portfel)
                MessageBox.Show($"Nie masz wystarczających środków, aby postawić {bet} zł", "Użytkownik 2");
            else
            {
                var chance = rnd.NextDouble();

                if (chance >= 0.75)
                {
                    MessageBox.Show($"Gratulację wygrałeś {bet * 2} zł", "Użytkownik 2");
                    user2.Portfel += (bet * 2);
                }
                else
                {
                    MessageBox.Show("Niestety, przegrałeś", "Użytkownik 2");
                    user2.Portfel -= bet;
                }

            }


            if (user2.Portfel <= 0)
            {
                req2TextBox.Text = "";
                req2TextBox.IsEnabled = false;
                var sen = sender as Button;
                sen.IsEnabled = false;
                portfel2TextBlock.Text = $"Portfel: jesteś spłukany";
            }
            else
                portfel2TextBlock.Text = $"Portfel: {user2.Portfel} zł";
        }
    }
}

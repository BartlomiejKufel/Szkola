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

namespace EgzPr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password = "";

        string smallLettersTab = "qwertyuiopasdfghjklzxcvbnm";
        string bigLettersTab = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string specialsTab = "!@#$%^&*()_+{}[]';:?/><.,|`~";
        string numbersTab = "0123456789";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            password = "";
            int.TryParse(passNumTextBox.Text, out int num);
            bool bigletters = (bool)letterCheckBox.IsChecked;
            bool numbers = (bool)numberCheckBox.IsChecked;
            bool specials = (bool)specialCheckBox.IsChecked;


            for (int i = 0; i < num; i++)
            {
                //małe litery
                password += smallLettersTab[rnd.Next(0,smallLettersTab.Length)];

                i++;
                if (i > num)
                    break;

                //duże litery
                if(bigletters)
                {
                    password += bigLettersTab[rnd.Next(0, bigLettersTab.Length)];
                    i++;
                    if (i > num)
                        break;
                }

                //znaki specjalne
                if(specials)
                {
                    password += specialsTab[rnd.Next(0, specialsTab.Length)];
                    i++;
                    if (i > num)
                        break;

                }

                //liczny
                if (numbers)
                {
                    password += numbersTab[rnd.Next(0, numbersTab.Length)];
                    i++;
                    if (i > num)
                        break;

                }

            }

            MessageBox.Show($"{password}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string position = positionComboBox.Text;
            
            MessageBox.Show($"Dane pracownika: {name} {surname}, {position}, Hasło: {password}");
        }
    }
}

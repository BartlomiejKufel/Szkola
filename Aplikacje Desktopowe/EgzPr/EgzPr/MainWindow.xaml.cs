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


            int t = 0; 
            for (int i = 0; i < num; i++)
            {
                //małe litery
                if (t == 0)
                {
                    password += smallLettersTab[rnd.Next(0,smallLettersTab.Length)];

                    if (!bigletters && !specials && !numbers)
                        t = 0;
                    else if (bigletters)
                        t++;
                    else if ((!bigletters && specials))
                        t = 2;
                    else if ((!bigletters && !specials && numbers))
                        t = 3;
                    
                    continue;
                }

                //duże litery
                if(t == 1 && bigletters)
                {
                    password += bigLettersTab[rnd.Next(0, bigLettersTab.Length)];
                    t++;
                    continue;
                }

                //znaki specjalne
                if (t == 2 && specials)
                {
                    password += specialsTab[rnd.Next(0, specialsTab.Length)];
                    t++;
                    continue;

                }

                //liczny
                if (t == 3 && numbers)
                {
                    password += numbersTab[rnd.Next(0, numbersTab.Length)];
                    t = 0;
                    continue;

                }

                t = 0;

            }

            MessageBox.Show($"{password}");
        }
    }
}

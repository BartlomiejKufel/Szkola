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
        private Person bartek = new Person("Bartek", 100, 0, 0);
        private Person janek = new Person("Janek", 100, 0, 0);
        private Person antek = new Person("Antek", 100, 0, 0);
        public MainWindow()
        {
            InitializeComponent();
            janekRadio.Content = $"{janek.Name} ma {janek.money} zł";

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



            }


        }

        private void ButtonStatus_Click(object sender, RoutedEventArgs e)
        {
            var sen = (Button)sender;
            if (status)
            {
                sen.Content = "nie stawia";
                dogNumberInput.IsEnabled = false;
                priceInput.IsEnabled = false;
                status = false;
            }
            else
            {
                sen.Content = "stawia";
                dogNumberInput.IsEnabled = true;
                priceInput.IsEnabled = true;
                status = true;
            }
        }
    }
}

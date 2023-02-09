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

namespace Location
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private new List<Locations> locations;
        string nameOfLocation = "";
        public MainWindow()
        {
            locations = new List<Locations>()
            {
                new Locations(){ Name = "Salon", Description = $"Stoisz w: Salon. Widzisz wyjścia do następujących lokalizacji: Jadalnia.", HaveDoor=true},
                new Locations(){ Name = "Jadalnia", Description = $"Stoisz w: Jadalnia. Widzisz wyjścia do następujących lokalizacji: Salon, Kuchnia.", HaveDoor=false},
                new Locations(){ Name = "Kuchnia", Description = $"Stoisz w: Kuchnia. Widzisz wyjścia do następujących lokalizacji: Jadalnia.", HaveDoor=true},
                new Locations(){ Name = "Podwórko przed domem", Description = $"Stoisz w: Podwórko przed domem. Widzisz wyjścia do następujących lokalizacji: Ogród, Podwórko za domem.", HaveDoor=true},
                new Locations(){ Name = "Podwórko za domem", Description = $"Stoisz w: Podwórko za domem. Widzisz wyjścia do następujących lokalizacji: Ogród, Podwórko przed domem.", HaveDoor=true},
                new Locations(){ Name = "Ogród", Description = $"Stoisz w: Ogród. Widzisz wyjścia do następujących lokalizacji: Podwórko za domem, Podwórko przed domem.", HaveDoor=false},
            };

            InitializeComponent();


            outputTextBox.Text = locations[0].Description;
            locationComboBox.Items.Add(locations[1].Name);
            locationComboBox.Items.Add(locations[3].Name);
            checkForDoor(locations[0]);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string loc = locationComboBox.Text;
            ChangeLocation(loc);
        }

        private void checkForDoor(Locations log)
        {
            if (log.HaveDoor)
            {
                doorButton.Visibility = Visibility.Visible;
            }
            else
            {
                doorButton.Visibility = Visibility.Hidden;
            }

            nameOfLocation = log.Name;
        }

        private void ChangeLocation(string loc)
        {
            locationComboBox.Items.Clear();

            switch (loc)
            {
                case "Salon":
                    outputTextBox.Text = locations[0].Description;
                    locationComboBox.Items.Add(locations[1].Name);
                    locationComboBox.Items.Add(locations[3].Name);
                    checkForDoor(locations[0]); 
                    break;

                case "Jadalnia":
                    outputTextBox.Text = locations[1].Description;
                    locationComboBox.Items.Add(locations[0].Name);
                    locationComboBox.Items.Add(locations[2].Name);
                    checkForDoor(locations[1]);
                    break;

                case "Kuchnia":
                    outputTextBox.Text = locations[2].Description;
                    locationComboBox.Items.Add(locations[1].Name);
                    locationComboBox.Items.Add(locations[4].Name);
                    checkForDoor(locations[2]);
                    break;

                case "Podwórko przed domem":
                    outputTextBox.Text = locations[3].Description;
                    locationComboBox.Items.Add(locations[0].Name);
                    locationComboBox.Items.Add(locations[4].Name);
                    locationComboBox.Items.Add(locations[5].Name);
                    checkForDoor(locations[3]);
                    break;

                case "Podwórko za domem":
                    outputTextBox.Text = locations[4].Description;
                    locationComboBox.Items.Add(locations[2].Name);
                    locationComboBox.Items.Add(locations[3].Name);
                    locationComboBox.Items.Add(locations[5].Name);
                    checkForDoor(locations[4]);
                    break;

                case "Ogród":
                    outputTextBox.Text = locations[5].Description;
                    locationComboBox.Items.Add(locations[3].Name);
                    locationComboBox.Items.Add(locations[4].Name);
                    checkForDoor(locations[5]);
                    break;

                default:
                    break;
            }


        }

        private void doorButton_Click(object sender, RoutedEventArgs e)
        {
            string log = nameOfLocation;

            locationComboBox.Items.Clear();
            switch (log)
            {
                case "Salon":
                    outputTextBox.Text = locations[3].Description;
                    locationComboBox.Items.Add(locations[0].Name);
                    locationComboBox.Items.Add(locations[4].Name);
                    locationComboBox.Items.Add(locations[5].Name);
                    checkForDoor(locations[3]);
                    break;

                case "Kuchnia":
                    outputTextBox.Text = locations[4].Description;
                    locationComboBox.Items.Add(locations[2].Name);
                    locationComboBox.Items.Add(locations[3].Name);
                    locationComboBox.Items.Add(locations[5].Name);
                    checkForDoor(locations[4]);
                    break;

                case "Podwórko przed domem":
                    outputTextBox.Text = locations[0].Description;
                    locationComboBox.Items.Add(locations[1].Name);
                    locationComboBox.Items.Add(locations[3].Name);
                    checkForDoor(locations[0]);
                    break;

                case "Podwórko za domem":
                    outputTextBox.Text = locations[2].Description;
                    locationComboBox.Items.Add(locations[1].Name);
                    locationComboBox.Items.Add(locations[4].Name);
                    checkForDoor(locations[2]);
                    break;

                
                default:
                    break;
            }

        }
    }
}

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
        private new List<Location> locations;
        public MainWindow()
        {
            locations = new List<Location>()
            {
                new Location(){ Name = "Salon", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Jadalnia.", HaveDoor=true},
                new Location(){ Name = "Jadalnia", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Salon, Kuchnia.", HaveDoor=false},
                new Location(){ Name = "Kuchnia", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Jadalnia.", HaveDoor=true},
                new Location(){ Name = "Podwórko przed domem", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Ogród, Podwórko za domem.", HaveDoor=true},
                new Location(){ Name = "Podwórko za domem", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Ogród, Podwórko przed domem.", HaveDoor=true},
                new Location(){ Name = "Ogród", Description = $"Stoisz w: {Name}. Wiszisz wyjścia do następujących lokalizacji: Podwórko za domem, Podwórko przed domem.", HaveDoor=false},
            };

            InitializeComponent();

            locationComboBox.ItemsSource = locations[2].Name;
            locationComboBox.ItemsSource = locations[].Name;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

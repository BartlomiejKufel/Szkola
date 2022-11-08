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

namespace Kontrolki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var sen = (RadioButton)sender;
            wynikTextBlock.Text = sen.Content.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var sen = (TextBox)sender;
            int rek =0;
            int.TryParse(sen.Text.ToString(),out rek);
            wynikTextBlock.Text =rek.ToString();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            var sen = (ListBoxItem)sender;
            wynikTextBlock.Text = sen.Content.ToString();
        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wynikTextBlock.Text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var sen = ((Slider)sender).Value;
            wynikTextBlock.Text = sen.ToString("0");
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var sen = ((Slider)sender).Value;

            wynikTextBlock.Text = sen.ToString("000-000-0000");
        }
    }
}

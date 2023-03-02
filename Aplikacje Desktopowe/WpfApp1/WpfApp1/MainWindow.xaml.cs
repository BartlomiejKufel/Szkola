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

namespace WpfApp1
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

        private void IterationMethod(object sender, RoutedEventArgs e)
        {
            outputListView.Items.Clear();
            int.TryParse(inputTextBox.Text, out int n);
            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    tab[i] = 1;
                else
                    tab[i] = tab[i - 1] + tab[i - 2];


                outputListView.Items.Add(tab[i].ToString());
            }
        }

        private void RecurationMethod(object sender, RoutedEventArgs e)
        {
            outputListView.Items.Clear();
            int.TryParse(inputTextBox.Text, out int n);

            int i = 0;
            while (i<n)
            {
                outputListView.Items.Add(Rec(i).ToString());
                i++;
            }
        }


        private int Rec(int n)
        {
            if(n==0 || n==1)
                return 1;
            else
                return Rec(n-1)+Rec(n-2);
        }
    }
}

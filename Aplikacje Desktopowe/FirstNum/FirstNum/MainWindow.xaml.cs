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

namespace FirstNum
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(startTextBox.Text, out int start);
            int.TryParse(endTextBox.Text, out int end);


            int[] tab = new int[end];
            int n = start;
            for (int i = 0; i < end-start; i++)
            {
                tab[i] = n;
                n++;
            }

            int a = 1;
            for(int i = start; i< Math.Sqrt(end); i++)
            {
               
                for (int j = a; j < tab.Length; j++)
                {
                    if (tab[j] == 1)
                    {
                        tab[j] = 0;
                    }
                    
                    if(tab[j] % i == 0 && i != 1)
                        tab[j] = 0;
                }
                a++;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] != 0 && tab[i] != 1)
                    outputListView.Items.Add(tab[i].ToString());
            }

        }
    }
}

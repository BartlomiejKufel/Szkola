using Microsoft.VisualBasic;
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

namespace ciagWpf
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
            int.TryParse(Interaction.InputBox("Podaj długość ciągu A", "Message").ToString(), out int aLeng);

            int[] A = new int[aLeng];

            for (int i = 0; i < aLeng; i++)
            {
                int.TryParse(Interaction.InputBox($"Podaj wartość dla indexu {i} w tablicy A", "Uzupełnij tablicę A").ToString(), out A[i]);
            }

            int count = 0, tmp;
            for (int i = 0; i < aLeng; i++)
            {
                if (i == 0)
                {
                    count += 2;
                    continue;
                }

                tmp = A[i - 1];
                if (tmp != A[i])
                {
                    count += 2;
                }

            }

            resultTextBox.Text = count.ToString();
        }
    }
}

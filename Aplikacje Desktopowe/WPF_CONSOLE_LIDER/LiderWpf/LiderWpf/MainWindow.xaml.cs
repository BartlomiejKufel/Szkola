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

namespace LiderWpf
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

        static void Main(string[] args)
        {
            Console.WriteLine("Tablica:");
            Console.WriteLine("Podaj długość tablicy");
            int arrLength;
            int.TryParse(Console.ReadLine(), out arrLength);
            int[] tab = GenerateArray(arrLength);

            Console.WriteLine();

            foreach (var item in tab.Select((value, i) => new { i, value }))
            {
                var index = item.i + 1;
                Console.WriteLine($"Pozycja:{index}-{item.value}");
            }
            Console.WriteLine($"Liderem jest: {FindLeader(tab)}");



        }


        public static int[] GenerateArray(int count)
        {
            int[] tab = new int[count];

            Random rand = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 3);
            }

            return tab;
        }

        public static int FindLeader(int[] tab)
        {
            var half = (tab.Length - 1) / 2;

            int leader = 0;
            int leaderCount = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                leader = tab[i];
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (leader == tab[j])
                        leaderCount++;
                }

                if (leaderCount >= half)
                {
                    return leader;
                }
                else
                {
                    leaderCount = 0;
                    leader = 0;
                }
            }


            return leader;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int arrLength = (int)iloscSlider.Value;

            GenerateArray(arrLength);

        }
    }
}

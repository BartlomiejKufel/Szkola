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

namespace karty
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

        public int[,] RandomCards(int[,] talia, int iloscKart)
        {
            int[] pulaKart = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 , 1, 1, 1};
            /*
             * index 0: As
             * index 1-9: liczby 2-10
             * index 10: Walet
             * index 11: Dama
             * index 12: Król
             */
            Random rand = new Random();

            for (int i = 0; i < iloscKart; i++)
            {
                int randCard = rand.Next(0,13);
                if (pulaKart[randCard] != 0)
                {
                    talia[i, 0] = randCard;
                    pulaKart[randCard] = 0;
                    talia[i, 1] = rand.Next(0, 4);
                }
                else
                    i--;
            }

            return talia;
        }

        public string ReadColors(int colorId)
        {
            switch (colorId)
            {
                case 0: return "karo";
                case 1: return "kier";
                case 2: return "trefl";
                case 3: return "pik";

                default: return "";

            }
        }

        public string ReadCards(int cardId)
        {
            switch (cardId)
            {
                case 0: return "As";
                case 1: return "2";
                case 2: return "3";
                case 3: return "4";
                case 4: return "5";
                case 5: return "6";
                case 6: return "7";
                case 7: return "8";
                case 8: return "9";
                case 9: return "10";
                case 10: return "Walet";
                case 11: return "Dama";
                case 12: return "Król";
                default: return "";
                    
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kartyListView.Items.Clear();
            int iloscKart = (int)iloscSlider.Value;
            int[,] talia = new int[iloscKart, 2];

            RandomCards(talia, iloscKart);


            for (int i = 0; i < iloscKart; i++)
            {
                kartyListView.Items.Add($"{ReadCards(talia[i, 0])} {ReadColors(talia[i, 1])}");

            }   
        }
    }
}

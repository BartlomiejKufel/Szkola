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
    public class Leader
    {
        public int LeaderInt { get; set; }
        public int LeaderCount { get; set; }

        public Leader(int leaderInt, int leaderCount)
        {
            LeaderInt = leaderInt;
            LeaderCount = leaderCount;
        }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        


        public static int[] FillArray(int[] tab)
        {
            Random rand = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 3);
            }

            return tab;
        }

        public static Leader FindLeader(int[] tab)
        {
            var half = (tab.Length) / 2;

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
                    leaderCount++;

                    Leader ld = new Leader(leader, leaderCount);
                    return ld;
                }
                else
                {
                    leaderCount = 0;
                    leader = 0;
                }
            }

            Leader ldr = new Leader(leader, leaderCount);
            return ldr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wypiszListView.Items.Clear();
            int arrLength = (int)iloscSlider.Value;

            int[] tab = new int[arrLength];

            FillArray(tab);

            foreach (var item in tab)
            {
                wypiszListView.Items.Add(item);
            }

            var leader = FindLeader(tab);
            
            lideraNumLabel.Content = leader.LeaderInt;
            lidearCountLabel.Content = leader.LeaderCount;

        }
    }
}

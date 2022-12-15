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
using System.Windows.Threading;

namespace cSharp_p_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new();
        private int time = 0;
        private DispatcherTimer Timer;
        List<string> animalEmoji = new()
        {
            "🦑","🦑",
            "🦆","🦆",
            "🐘","🐘",
            "🐳","🐳",
            "🐈","🐈",
            "🦍","🦍",
            "🦔","🦔",
            "🦚","🦚"
        };
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            


        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            time++;
            timerTextBlock.Content = String.Format("{0},{1}s", time/60 ,time%60);
        }

        private void GameStart_Click(object sender, RoutedEventArgs e)
        {
            gameButton.IsEnabled = false;
            gameButton.Visibility = Visibility.Collapsed;
            timerTextBlock.Visibility = Visibility.Visible;

            foreach (TextBlock iconLabel in gameBoard.Children)
            {
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(animalEmoji.Count);
                    iconLabel.Text = animalEmoji[randomNumber];
                    animalEmoji.RemoveAt(randomNumber);
                }
            }

            Timer.Interval = new TimeSpan(0,0,0,0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
    }
}

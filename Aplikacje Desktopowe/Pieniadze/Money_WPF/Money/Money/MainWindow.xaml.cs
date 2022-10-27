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

namespace Money
{
    public partial class MainWindow : Window
    {
        Person jacek = new Person() { Name = "Jacek", Money = 50 };
        Person bartek = new Person() { Name = "Bartek", Money = 100 };
        Person command = new Person();

        public MainWindow()
        {
            InitializeComponent();

            command.ShowInfo(jacek, bartek);

        }

        private void Button_Click_Jacek(object sender, RoutedEventArgs e)
        {
            ErrorTextBlock.Text = "";
            var money =0;
            int.TryParse(moneyTextBox.Text.Trim(), out money);

            int tmp = jacek.GiveMoney(money, jacek);
            if (tmp == 0)
            {
                ErrorTextBlock.Text = $"{jacek.Name} mówi: nie mam wystarczająco środków aby dać ci {money} zł.";
            }
            else
            {
                bartek.TakeMoney(tmp, bartek);
            }

            command.ShowInfo(jacek, bartek);
        }


        private void Button_Click_Bartek(object sender, RoutedEventArgs e)
        {
            ErrorTextBlock.Text = "";
            var money = 0;
            int.TryParse(moneyTextBox.Text.Trim(), out money);

            int tmp = bartek.GiveMoney(money, bartek);
            if (tmp == 0)
            {
                ErrorTextBlock.Text=$"{bartek.Name} mówi: nie mam wystarczająco środków aby dać ci {money} zł.";
            }
            else
            {
                jacek.TakeMoney(tmp, jacek);
            }

            command.ShowInfo(jacek, bartek);
        }
    }
}

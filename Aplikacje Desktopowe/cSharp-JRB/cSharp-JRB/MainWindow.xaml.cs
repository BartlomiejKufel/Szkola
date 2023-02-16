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

namespace cSharp_JRB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int money=200;
        public int[] machinSlots = new int[3] {4,4,4};
        public MainWindow()
        {
            InitializeComponent();

            ChangeMachineSlots(false);
            SetMoney();
        }

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (money <= 0)
            {
                MessageBox.Show("Nie masz pieniędzy");
                return;
            }

            ChangeMachineSlots(true);

            await Task.Delay(3150);
            if (machinSlots[0] == 9 && machinSlots[1] == 9 && machinSlots[2] == 9)
                money += 5000;
            else
                money -= 5;

            SetMoney();
        }


        private async void ChangeMachineSlots(bool dramatic)
        {

            if (dramatic)
            {
                Random rnd = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        machinSlots[i] = rnd.Next(1, 10);
                        await Task.Delay(80);

                        switch (i)
                        {
                            case 0: machineSlot1.Text = machinSlots[i].ToString(); break;
                            case 1: machineSlot2.Text = machinSlots[i].ToString(); break;
                            case 2: machineSlot3.Text = machinSlots[i].ToString(); break;
                        }
                    }
                }
            }
            else
            {
                machineSlot1.Text = machinSlots[0].ToString();
                machineSlot2.Text = machinSlots[1].ToString();
                machineSlot3.Text = machinSlots[2].ToString();
            }


        }


        private void SetMoney()
        {
            moneyTextBox.Text = $"{money} $"; 
        }
    }
}

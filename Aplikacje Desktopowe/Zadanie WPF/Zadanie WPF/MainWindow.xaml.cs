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

namespace Zadanie_WPF
{
    /// <summary>
    /// Kółko krzyżyk
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        bool playerTurn = true;
        string[,] gameBoard = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        int[] pickFields = new int[9];
        int moves = 0;
        int aiMove;
        bool target;
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool CheckForWinX(string[,] gameBoard)
        {
            if (gameBoard[0, 0] == "X" && gameBoard[0, 1] == "X" && gameBoard[0, 2] == "X")
                return true;
            
            if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
                return true;

            if (gameBoard[2, 0] == "X" && gameBoard[2, 1] == "X" && gameBoard[2, 2] == "X")
                return true;


            if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2, 0] == "X")
                return true;
            
            if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
                return true;
            
            if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
                return true;

            if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
                return true;

            if (gameBoard[0, 2] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 0] == "X")
                return true;

            return false;
        }

        public bool CheckForWinO(string[,] gameBoard)
        {
            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
                return true;

            if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
                return true;

            if (gameBoard[2, 0] == "O" && gameBoard[2, 1] == "O" && gameBoard[2, 2] == "O")
                return true;


            if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
                return true;

            if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
                return true;

            if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
                return true;

            if (gameBoard[0, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 2] == "O")
                return true;

            if (gameBoard[0, 2] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 0] == "O")
                return true;

            return false;
        }


        private void Game_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Content = "X";
            btn.IsEnabled = false;

            switch (btn.Name.ToString())
            {
                case "field0": pickFields[moves] = 0; gameBoard[0, 0] = "X"; break;
                case "field1": pickFields[moves] = 1; gameBoard[0, 1] = "X"; break;
                case "field2": pickFields[moves] = 2; gameBoard[0, 2] = "X"; break;
                case "field3": pickFields[moves] = 3; gameBoard[1, 0] = "X"; break;
                case "field4": pickFields[moves] = 4; gameBoard[1, 1] = "X"; break;
                case "field5": pickFields[moves] = 5; gameBoard[1, 2] = "X"; break;
                case "field6": pickFields[moves] = 6; gameBoard[2, 0] = "X"; break;
                case "field7": pickFields[moves] = 7; gameBoard[2, 1] = "X"; break;
                case "field8": pickFields[moves] = 8; gameBoard[2, 2] = "X"; break;
            }

            moves++;

            if (moves >= 9)
                MessageBox.Show("Skończyły się ruchy", "OK");
            else
            {
                Random random = new Random();

                while (true)
                {
                    aiMove = random.Next(0, 9);
                    target = Array.Exists(pickFields, x => x.Equals(aiMove));
                    if (!target)
                    {
                        switch (aiMove)
                        {
                            case 0: field0.Content = "O"; field0.IsEnabled = false; pickFields[moves] = 0; gameBoard[0, 0] = "O"; break;
                            case 1: field1.Content = "O"; field1.IsEnabled = false; pickFields[moves] = 1; gameBoard[0, 1] = "O"; break;
                            case 2: field2.Content = "O"; field2.IsEnabled = false; pickFields[moves] = 2; gameBoard[0, 2] = "O"; break;
                            case 3: field3.Content = "O"; field3.IsEnabled = false; pickFields[moves] = 3; gameBoard[1, 0] = "O"; break;
                            case 4: field4.Content = "O"; field4.IsEnabled = false; pickFields[moves] = 4; gameBoard[1, 1] = "O"; break;
                            case 5: field5.Content = "O"; field5.IsEnabled = false; pickFields[moves] = 5; gameBoard[1, 2] = "O"; break;
                            case 6: field6.Content = "O"; field6.IsEnabled = false; pickFields[moves] = 6; gameBoard[2, 0] = "O"; break;
                            case 7: field7.Content = "O"; field7.IsEnabled = false; pickFields[moves] = 7; gameBoard[2, 1] = "O"; break;
                            case 8: field8.Content = "O"; field8.IsEnabled = false; pickFields[moves] = 8; gameBoard[2, 2] = "O"; break;
                        }
                    }
                    else continue;
                    break;
                }

                moves++;
            }

            if (CheckForWinX(gameBoard))
            {
                MessageBox.Show("Wygrał X", "Ok");
                this.Close();
            }

            if (CheckForWinO(gameBoard))
            {
                MessageBox.Show("Wygrał O", "Ok");
                this.Close();
            }




        }
    }
}

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
using System.Windows.Shapes;

namespace OX_Sharp
{
    /// <summary>
    /// Interaction logic for MainGame.xaml
    /// </summary>
    public partial class MainGame : Window
    {
        int NowPlayer = 1;
        int choose = 0;
        int re_i;
        string item1 = "X", item2 = "O", item3 = "#";
        string[] item = {"X", "O", "#"};
        string[] re_table = {"1","2","3","4","5","6","7","8"
                     ,"9","10","11","12","13","14","15","16"};
        string[] table = {"1","2","3","4","5","6","7","8"
                     ,"9","10","11","12","13","14","15","16"};
        int X = 0, O = 0, Sp = 0, Star = 0;
        int X1 = 5, O1 = 4, Sp1 = 1, Star1 = 0;
        int X2 = 4, O2 = 5, Sp2 = 0, Star2 = 1;

        bool[] Cbtn = {true,true,true,true,true,true,true,true
                     ,true,true,true,true,true,true,true,true};

        public MainGame(MainWindow mainWindow, string name1, string name2)
        {
            InitializeComponent();

            if(name1 != "" && name2 != "")
            {
                txtName1.Content = name1;
                txtName2.Content = name2;
            }

            ShowOXSP();
            DoNot();
        }

        public void PlayerSwitch()
        {
            if(NowPlayer == 1)
            {
                NowPlayer = 2;
                btnX1.IsEnabled = false;
                btnO1.IsEnabled = false;
                btnSp1.IsEnabled = false;
                btnStar1_1.IsEnabled = false;
                btnStar1_3.IsEnabled = false;
                btnStar1_21.IsEnabled = false;
                btnStar1_22.IsEnabled = false;
                btnX2.IsEnabled = true;
                btnO2.IsEnabled = true;
                btnSp2.IsEnabled = true;
                btnStar2_1.IsEnabled = true;
                btnStar2_3.IsEnabled = true;
                btnStar2_21.IsEnabled = true;
                btnStar2_22.IsEnabled = true;
            }
            else if (NowPlayer == 2)
            {
                NowPlayer = 1;
                btnX1.IsEnabled = true;
                btnO1.IsEnabled = true;
                btnSp1.IsEnabled = true;
                btnStar1_1.IsEnabled = true;
                btnStar1_3.IsEnabled = true;
                btnStar1_21.IsEnabled = true;
                btnStar1_22.IsEnabled = true;
                btnX2.IsEnabled = false;
                btnO2.IsEnabled = false;
                btnSp2.IsEnabled = false;
                btnStar2_1.IsEnabled = false;
                btnStar2_3.IsEnabled = false;
                btnStar2_21.IsEnabled = false;
                btnStar2_22.IsEnabled = false;
            }
            DoNot();
            txtInfo.Text = "now player " + NowPlayer;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[0])
            {
                re_i = 0;
                table[0] = item[choose];
                Cbtn[0] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[1])
            {
                re_i = 1;
                table[1] = item[choose];
                Cbtn[1] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[2])
            {
                re_i = 2;
                table[2] = item[choose];
                Cbtn[2] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[3])
            {
                re_i = 3;
                table[3] = item[choose];
                Cbtn[3] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[4])
            {
                re_i = 4;
                table[4] = item[choose];
                Cbtn[4] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[5])
            {
                re_i = 5;
                table[5] = item[choose];
                Cbtn[5] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[6])
            {
                re_i = 6;
                table[6] = item[choose];
                Cbtn[6] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[7])
            {
                re_i = 7;
                table[7] = item[choose];
                Cbtn[7] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[8])
            {
                re_i = 8;
                table[8] = item[choose];
                Cbtn[8] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[9])
            {
                re_i = 9;
                table[9] = item[choose];
                Cbtn[9] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[10])
            {
                re_i = 10;
                table[10] = item[choose];
                Cbtn[10] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[11])
            {
                re_i = 11;
                table[11] = item[choose];
                Cbtn[11] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[12])
            {
                re_i = 12;
                table[12] = item[choose];
                Cbtn[12] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[13])
            {
                re_i = 13;
                table[13] = item[choose];
                Cbtn[13] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[14])
            {
                re_i = 14;
                table[14] = item[choose];
                Cbtn[14] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (Cbtn[15])
            {
                re_i = 15;
                table[15] = item[choose];
                Cbtn[15] = false;
                reduceOXSP();
                addPoint();
                PlayerSwitch();
                SetNameBtn();
                SwitchBtnFalse();
                WinOrLost();
            }
        }

        private void btnX1_Click(object sender, RoutedEventArgs e)
        {
            choose = 0;
            txtInfo.Text = "use : X";
            SwitchBtnTrue();
        }

        private void btnO1_Click(object sender, RoutedEventArgs e)
        {
            choose = 1;
            txtInfo.Text = "use : O";
            SwitchBtnTrue();
        }

        private void btnSp1_Click(object sender, RoutedEventArgs e)
        {
            choose = 2;
            txtInfo.Text = "use : #";
            SwitchBtnTrue();
        }

        private void btnStar1_1_Click(object sender, RoutedEventArgs e)
        {
            Star1 -= 1;
            ShowOXSP();
            PlayerSwitch();
            WinOrLost();
        }

        private void btnStar1_3_Click(object sender, RoutedEventArgs e)
        {
            Star1 -= 3;
            Sp1 += 1;
            ShowOXSP();
            PlayerSwitch();
            WinOrLost();
        }

        private void btnStar1_21_Click(object sender, RoutedEventArgs e)
        {
            Star1 -= 2;
            X1 += 1;
            ShowOXSP();
            DoNot();
            WinOrLost();
        }

        private void btnStar1_22_Click(object sender, RoutedEventArgs e)
        {
            Star1 -= 2;
            O1 += 1;
            ShowOXSP();
            DoNot();
            WinOrLost();
        }

        private void btnX2_Click(object sender, RoutedEventArgs e)
        {
            choose = 0;
            txtInfo.Text = "use : X";
            SwitchBtnTrue();
        }

        private void btnO2_Click(object sender, RoutedEventArgs e)
        {
            choose = 1;
            txtInfo.Text = "use : O";
            SwitchBtnTrue();
        }

        private void btnSp2_Click(object sender, RoutedEventArgs e)
        {
            choose = 2;
            txtInfo.Text = "use : #";
            SwitchBtnTrue();
        }

        private void btnStar2_1_Click(object sender, RoutedEventArgs e)
        {
            Star2 -= 1;
            ShowOXSP();
            PlayerSwitch();
            WinOrLost();
        }

        private void btnStar2_3_Click(object sender, RoutedEventArgs e)
        {
            Star2 -= 3;
            Sp2 += 1;
            ShowOXSP();
            PlayerSwitch();
            WinOrLost();
        }

        private void btnStar2_21_Click(object sender, RoutedEventArgs e)
        {
            Star2 -= 2;
            X2 += 1;
            ShowOXSP();
            DoNot();
            WinOrLost();
        }

        private void btnStar2_22_Click(object sender, RoutedEventArgs e)
        {
            Star2 -= 2;
            O2 += 1;
            ShowOXSP();
            DoNot();
            WinOrLost();
        }

        public void SetNameBtn()
        {
            btn1.Content = table[0];
            btn2.Content = table[1];
            btn3.Content = table[2];
            btn4.Content = table[3];
            btn5.Content = table[4];
            btn6.Content = table[5];
            btn7.Content = table[6];
            btn8.Content = table[7];
            btn9.Content = table[8];
            btn10.Content = table[9];
            btn11.Content = table[10];
            btn12.Content = table[11];
            btn13.Content = table[12];
            btn14.Content = table[13];
            btn15.Content = table[14];
            btn16.Content = table[15];
        }

        public void SwitchBtnTrue()
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
        }

        public void SwitchBtnFalse()
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btn10.IsEnabled = false;
            btn11.IsEnabled = false;
            btn12.IsEnabled = false;
            btn13.IsEnabled = false;
            btn14.IsEnabled = false;
            btn15.IsEnabled = false;
            btn16.IsEnabled = false;
        }

        public void addPoint()
        {
            try
            {
                int add = 0;
                for (int i = 0; i <= 2; i++)
                {
                    if (table[re_i] == item[i])
                    {
                        if (re_i == 3 || re_i == 7 || re_i == 11 || re_i == 15)
                        {
                            if (table[re_i] == item[i] && table[re_i - 1] == item[i] && table[re_i - 2] == item[i])
                            {
                                //
                                add = 1;
                                Cbtn[re_i] = true;
                                Cbtn[re_i - 1] = true;
                                Cbtn[re_i - 2] = true;

                                table[re_i] = re_table[re_i];
                                table[re_i - 1] = re_table[re_i - 1];
                                table[re_i - 2] = re_table[re_i - 2];
                            }
                        }
                        else if (re_i == 0 || re_i == 4 || re_i == 8 || re_i == 12)
                        {
                            if (table[re_i] == item[i] && table[re_i + 1] == item[i] && table[re_i + 2] == item[i])
                            {
                                //
                                add = 1;
                                Cbtn[re_i] = true;
                                Cbtn[re_i + 1] = true;
                                Cbtn[re_i + 2] = true;

                                table[re_i] = re_table[re_i];
                                table[re_i + 1] = re_table[re_i + 1];
                                table[re_i + 2] = re_table[re_i + 2];
                            }
                        }
                        else
                        {
                            if (table[re_i] == item[i] && table[re_i - 1] == item[i] && table[re_i + 1] == item[i])
                            {
                                //
                                add = 1;
                                Cbtn[re_i] = true;
                                Cbtn[re_i - 1] = true;
                                Cbtn[re_i + 1] = true;

                                table[re_i] = re_table[re_i];
                                table[re_i - 1] = re_table[re_i - 1];
                                table[re_i + 1] = re_table[re_i + 1];
                            }
                            if (table[re_i] == item[i] && table[re_i - 1] == item[i] && table[re_i - 2] == item[i])
                            {
                                //
                                if (re_i - 1 != 4 && re_i - 1 != 8 && re_i - 1 != 12)
                                {
                                    add = 1;
                                    Cbtn[re_i] = true;
                                    Cbtn[re_i - 1] = true;
                                    Cbtn[re_i - 2] = true;

                                    table[re_i] = re_table[re_i];
                                    table[re_i - 1] = re_table[re_i - 1];
                                    table[re_i - 2] = re_table[re_i - 2];
                                }
                                //
                            }
                            if (table[re_i] == item[i] && table[re_i + 1] == item[i] && table[re_i + 2] == item[i])
                            {
                                //
                                if (re_i + 1 != 3 && re_i + 1 != 7 && re_i + 1 != 11)
                                {
                                    add = 1;
                                    Cbtn[re_i] = true;
                                    Cbtn[re_i + 1] = true;
                                    Cbtn[re_i + 2] = true;

                                    table[re_i] = re_table[re_i];
                                    table[re_i + 1] = re_table[re_i + 1];
                                    table[re_i + 2] = re_table[re_i + 2];
                                }
                                //	
                            }
                        }
                    }

                    if (add == 1)
                    {
                        add = 0;
                        if (item[i] == item1)
                        {
                            X += 3;
                            Star += 1;
                        }
                        else if (item[i] == item2)
                        {
                            O += 3;
                            Star += 1;
                        }
                        else if (item[i] == item3)
                        {
                            Sp += 3;
                            Star += 1;
                        }
                    }

                }
                //////////////////////////////////////////////
                for (int i = 0; i <= 2; i++)
                {
                    if (table[re_i] == item[i])
                    {
                        if (table[0] == item[i] && table[5] == item[i] && table[10] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[0] = true;
                            Cbtn[5] = true;
                            Cbtn[10] = true;

                            table[0] = re_table[0];
                            table[5] = re_table[5];
                            table[10] = re_table[10];
                        }
                        else if (table[1] == item[i] && table[6] == item[i] && table[11] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[1] = true;
                            Cbtn[6] = true;
                            Cbtn[11] = true;

                            table[1] = re_table[1];
                            table[6] = re_table[6];
                            table[11] = re_table[11];
                        }
                        else if (table[4] == item[i] && table[9] == item[i] && table[14] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[4] = true;
                            Cbtn[9] = true;
                            Cbtn[14] = true;

                            table[4] = re_table[4];
                            table[9] = re_table[9];
                            table[14] = re_table[14];
                        }
                        else if (table[5] == item[i] && table[10] == item[i] && table[15] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[5] = true;
                            Cbtn[10] = true;
                            Cbtn[15] = true;

                            table[5] = re_table[5];
                            table[10] = re_table[10];
                            table[15] = re_table[15];
                        }
                    }

                    if (add == 1)
                    {
                        add = 0;
                        if (item[i] == item1)
                        {
                            X += 3;
                            Star += 1;
                        }
                        else if (item[i] == item2)
                        {
                            O += 3;
                            Star += 1;
                        }
                        else if (item[i] == item3)
                        {
                            Sp += 3;
                            Star += 1;
                        }
                    }

                }
                //////////////////////////////////////////////
                for (int i = 0; i <= 2; i++)
                {
                    if (table[re_i] == item[i])
                    {
                        if (table[2] == item[i] && table[5] == item[i] && table[8] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[2] = true;
                            Cbtn[5] = true;
                            Cbtn[8] = true;

                            table[2] = re_table[2];
                            table[5] = re_table[5];
                            table[8] = re_table[8];
                        }
                        else if (table[3] == item[i] && table[6] == item[i] && table[9] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[3] = true;
                            Cbtn[6] = true;
                            Cbtn[9] = true;

                            table[3] = re_table[3];
                            table[6] = re_table[6];
                            table[9] = re_table[9];
                        }
                        else if (table[6] == item[i] && table[9] == item[i] && table[12] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[6] = true;
                            Cbtn[9] = true;
                            Cbtn[12] = true;

                            table[6] = re_table[6];
                            table[9] = re_table[9];
                            table[12] = re_table[12];
                        }
                        else if (table[7] == item[i] && table[10] == item[i] && table[13] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[7] = true;
                            Cbtn[10] = true;
                            Cbtn[13] = true;

                            table[7] = re_table[7];
                            table[10] = re_table[10];
                            table[13] = re_table[13];
                        }
                    }

                    if (add == 1)
                    {
                        add = 0;
                        if (item[i] == item1)
                        {
                            X += 3;
                            Star += 1;
                        }
                        else if (item[i] == item2)
                        {
                            O += 3;
                            Star += 1;
                        }
                        else if (item[i] == item3)
                        {
                            Sp += 3;
                            Star += 1;
                        }
                    }

                }
                //////////////////////////////////////////////
                for (int i = 0; i <= 2; i++)
                {
                    if (table[re_i] == item[i])
                    {
                        if (re_i >= 8)
                        {
                            if (table[re_i] == item[i] && table[re_i - 4] == item[i] && table[re_i - 8] == item[i])
                            {
                                //
                                add = 1;
                                Cbtn[re_i] = true;
                                Cbtn[re_i - 4] = true;
                                Cbtn[re_i - 8] = true;

                                table[re_i] = re_table[re_i];
                                table[re_i - 4] = re_table[re_i - 4];
                                table[re_i - 8] = re_table[re_i - 8];
                            }
                            if (re_i >= 8 && re_i <= 11)
                            {
                                if (table[re_i] == item[i] && table[re_i - 4] == item[i] && table[re_i + 4] == item[i])
                                {
                                    //
                                    add = 1;
                                    Cbtn[re_i] = true;
                                    Cbtn[re_i - 4] = true;
                                    Cbtn[re_i + 4] = true;

                                    table[re_i] = re_table[re_i];
                                    table[re_i - 4] = re_table[re_i - 4];
                                    table[re_i + 4] = re_table[re_i + 4];
                                }
                            }
                        }
                        else if (re_i >= 4 && re_i <= 7)
                        {
                            if (table[re_i] == item[i] && table[re_i - 4] == item[i] && table[re_i + 4] == item[i])
                            {
                                //
                                add = 1;
                                Cbtn[re_i] = true;
                                Cbtn[re_i - 4] = true;
                                Cbtn[re_i + 4] = true;

                                table[re_i] = re_table[re_i];
                                table[re_i - 4] = re_table[re_i - 4];
                                table[re_i + 4] = re_table[re_i + 4];
                            }
                        }
                        if (table[re_i] == item[i] && table[re_i + 4] == item[i] && table[re_i + 8] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[re_i] = true;
                            Cbtn[re_i + 4] = true;
                            Cbtn[re_i + 8] = true;

                            table[re_i] = re_table[re_i];
                            table[re_i + 4] = re_table[re_i + 4];
                            table[re_i + 8] = re_table[re_i + 8];
                        }
                        if (table[re_i] == item[i] && table[re_i - 4] == item[i] && table[re_i - 8] == item[i])
                        {
                            //
                            add = 1;
                            Cbtn[re_i] = true;
                            Cbtn[re_i - 4] = true;
                            Cbtn[re_i - 8] = true;

                            table[re_i] = re_table[re_i];
                            table[re_i - 4] = re_table[re_i - 4];
                            table[re_i - 8] = re_table[re_i - 8];
                        }
                    }

                    if (add == 1)
                    {
                        add = 0;
                        if (item[i] == item1)
                        {
                            X += 3;
                            Star += 1;
                        }
                        else if (item[i] == item2)
                        {
                            O += 3;
                            Star += 1;
                        }
                        else if (item[i] == item3)
                        {
                            Sp += 3;
                            Star += 1;
                        }
                    }

                }
                addOXSP();
            }
            catch
            {
                ShowOXSP();
            }
        }

        public void addOXSP()
        {
            if(NowPlayer == 1)
            {
                X1 += X;
                O1 += O;
                Sp1 += Sp;

                Star2 += Star;
            }
            else if (NowPlayer == 2)
            {
                X2 += X;
                O2 += O;
                Sp2 += Sp;

                Star1 += Star;
            }

            X = 0;
            O = 0;
            Sp = 0;
            Star = 0;

            ShowOXSP();
        }

        public void ShowOXSP()
        {
            txtX1.Text = X1.ToString();
            txtO1.Text = O1.ToString();
            txtSp1.Text = Sp1.ToString();
            txtStar1.Text = Star1.ToString();

            txtX2.Text = X2.ToString();
            txtO2.Text = O2.ToString();
            txtSp2.Text = Sp2.ToString();
            txtStar2.Text = Star2.ToString();
        }

        public void reduceOXSP()
        {
            if(item[choose] == item1)
            {
                X -= 1;
            }
            else if (item[choose] == item2)
            {
                O -= 1;
            }
            else if (item[choose] == item3)
            {
                Sp -= 1;
            }

            addOXSP();

            X = 0;
            O = 0;
            Sp = 0;
        }

        public void DoNot()
        {
            if(NowPlayer == 1)
            {
                if (X1 == 0)
                {
                    btnX1.IsEnabled = false;
                }
                else
                {
                    btnX1.IsEnabled = true;
                }
                if (O1 == 0)
                {
                    btnO1.IsEnabled = false;
                }
                else
                {
                    btnO1.IsEnabled = true;
                }
                if (Sp1 == 0)
                {
                    btnSp1.IsEnabled = false;
                }
                else
                {
                    btnSp1.IsEnabled = true;
                }
                if (Star1 == 0)
                {
                    btnStar1_1.IsEnabled = false;
                }
                else
                {
                    btnStar1_1.IsEnabled = true;
                }
                if (Star1 < 2)
                {
                    btnStar1_21.IsEnabled = false;
                    btnStar1_22.IsEnabled = false;
                }
                else
                {
                    btnStar1_21.IsEnabled = true;
                    btnStar1_22.IsEnabled = true;
                }
                if (Star1 < 3)
                {
                    btnStar1_3.IsEnabled = false;
                }
                else
                {
                    btnStar1_3.IsEnabled = true;
                }
            }

            if(NowPlayer == 2)
            {
                if (X2 == 0)
                {
                    btnX2.IsEnabled = false;
                }
                else
                {
                    btnX2.IsEnabled = true;
                }
                if (O2 == 0)
                {
                    btnO2.IsEnabled = false;
                }
                else
                {
                    btnO2.IsEnabled = true;
                }
                if (Sp2 == 0)
                {
                    btnSp2.IsEnabled = false;
                }
                else
                {
                    btnSp2.IsEnabled = true;
                }
                if (Star2 == 0)
                {
                    btnStar2_1.IsEnabled = false;
                }
                else
                {
                    btnStar2_1.IsEnabled = true;
                }
                if (Star2 < 2)
                {
                    btnStar2_21.IsEnabled = false;
                    btnStar2_22.IsEnabled = false;
                }
                else
                {
                    btnStar2_21.IsEnabled = true;
                    btnStar2_22.IsEnabled = true;
                }
                if (Star2 < 3)
                {
                    btnStar2_3.IsEnabled = false;
                }
                else
                {
                    btnStar2_3.IsEnabled = true;
                }
            }
        }

        public void WinOrLost()
        {
            if ((X1 == 0 && O1 == 0 && Sp1 == 0 && Star1 == 0)
                || Star2 >= 6)
            {
                allFalse();
                MessageBox.Show("Player 2 Win");
                txtInfo.Text = "Player 2 Win";
            }
            if ((X2 == 0 && O2 == 0 && Sp2 == 0 && Star2 == 0)
                || Star1 >= 6)
            {
                allFalse();
                MessageBox.Show("Player 1 Win");
                txtInfo.Text = "Player 1 Win";
            }
            for (int i = 0; i <= 15; i++)
            {
                if (i == 15)
                {
                    if (Cbtn[15] == false)
                    {
                        allFalse();
                        MessageBox.Show("Draw!!!");
                        txtInfo.Text = "Draw!!!";
                    }
                }
                else if (Cbtn[i] == false)
                {
                    continue;
                }
                else if (Cbtn[i] == true)
                {
                    break;
                }
            }
        }

        public void allFalse()
        {
            btnX1.IsEnabled = false;
            btnO1.IsEnabled = false;
            btnSp1.IsEnabled = false;
            btnStar1_1.IsEnabled = false;
            btnStar1_3.IsEnabled = false;
            btnStar1_21.IsEnabled = false;
            btnStar1_22.IsEnabled = false;
            btnX2.IsEnabled = false;
            btnO2.IsEnabled = false;
            btnSp2.IsEnabled = false;
            btnStar2_1.IsEnabled = false;
            btnStar2_3.IsEnabled = false;
            btnStar2_21.IsEnabled = false;
            btnStar2_22.IsEnabled = false;

            SwitchBtnFalse();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(this);
            mainWindow.Show();
            this.Close();
        }
    }
}

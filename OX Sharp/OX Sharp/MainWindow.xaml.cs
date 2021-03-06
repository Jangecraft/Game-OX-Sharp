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
using System.Diagnostics;

namespace OX_Sharp
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

        public MainWindow(MainGame mainGame)
        {
            InitializeComponent();
        }

        public MainWindow(BotGame mainGame)
        {
            InitializeComponent();
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text;
            MainGame mainGame = new MainGame(this, Name1, Name2);
            mainGame.Show();
            this.Close();
        }

        private void Play_Bot_Button_Click(object sender, RoutedEventArgs e)
        {
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text + " (Bot)";
            BotGame botGame = new BotGame(this, Name1, Name2);
            botGame.Show();
            this.Close();
        }

        private void HowToPlay_Button_Click(object sender, RoutedEventArgs e)
        {
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://phumipatwebsite.000webhostapp.com/OX%20Sharp.html";
            Process.Start(prs);
        }
    }
}

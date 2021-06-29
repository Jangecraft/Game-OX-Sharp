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
        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text;
            MainGame mainGame = new MainGame(this, Name1, Name2);
            mainGame.Show();
            this.Close();
        }
    }
}

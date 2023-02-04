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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            game.IsEnabled = true;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "х");
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "о");
                    player = 1;
                    break;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;

            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
        }
        private void win()
        {
            
        }
    }
}

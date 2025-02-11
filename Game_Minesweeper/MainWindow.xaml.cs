using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace Game_Minesweeper
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


        private void btnSpace_Click(object sender, RoutedEventArgs e)
        {
            //hide the selected button
            Button space = (Button)sender;

            space.Visibility = Visibility.Hidden;
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            //Close the program
            Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developers: Justin Borchert, Ilhan Hashi, and Nai'a Suda\nVersion: 1.0\nDate: 2/10/25");
        }
    }
}

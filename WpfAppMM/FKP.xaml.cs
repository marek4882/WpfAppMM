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

namespace WpfAppMM
{
    /// <summary>
    /// Logika interakcji dla klasy Formularz.xaml
    /// </summary>
    public partial class Formularz : Window
    {
        public Formularz()
        {
            InitializeComponent();
        }

        private void Click_Button_Back_1(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }


        private void Navigator_3(object sender, RoutedEventArgs e)
        {
            FKF fkf = new FKF();
            fkf.Show();
            this.Close();
        }
    }
}

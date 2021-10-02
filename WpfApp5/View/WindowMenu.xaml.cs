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

namespace WpfApp5.View
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAllMaterials windowAllMaterials = new WindowAllMaterials();
            windowAllMaterials.Show();
            this.Close();
        }
    }
}

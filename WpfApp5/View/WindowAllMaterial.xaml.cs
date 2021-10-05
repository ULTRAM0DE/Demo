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
    /// Логика взаимодействия для WindowAllMaterial.xaml
    /// </summary>
    public partial class WindowAllMaterial : Window
    {
        private static List<View.ViewMaterial> content = new List<ViewMaterial>();
        public WindowAllMaterial()
        {
            InitializeComponent();
            content = GetContent();
            Run(content);
        }

     
            private void Run(List<ViewMaterial> content)
        {
            lbContent.ItemsSource = null;
            lbContent.ItemsSource = content;
        }
     

        private List<ViewMaterial> GetContent()
        {
            try
            {
                return Controller.ControllerMaterial.GetViews();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAddService windowAddService = new WindowAddService();
            windowAddService.Show();
            this.Close();
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowMenu windowMenu = new WindowMenu();
            windowMenu.Show();
            this.Close();
        }
    }
}

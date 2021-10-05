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
    /// Логика взаимодействия для WindowAddService.xaml
    /// </summary>
    public partial class WindowAddService : Window
    {
        public WindowAddService()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Имя не задано");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                MessageBox.Show("Введите цену");
                return;
            }

                if(string.IsNullOrWhiteSpace(tbSale.Text))
            {
                MessageBox.Show("Введите скидку, или если ее нет то введите значение 0");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTime.Text))
            {
                MessageBox.Show("Введите время выполнения(В часах)");
                return;
            }
           
            try
            {
                if(Controller.ControllerMaterial.AddService(tbName.Text, tbPrice.Text, tbSale.Text, tbTime.Text))
                {
                    MessageBox.Show("Обьект добавлен в БД");
                }
                else
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAllMaterial windowAllMaterial = new WindowAllMaterial();
            windowAllMaterial.Show();
            this.Close();
        }
    }
}

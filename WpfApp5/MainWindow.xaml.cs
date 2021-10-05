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
using WpfApp5.DB;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txLogin.Text = "GGWP";
            txPassword.Text = "123";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var user = Auntification.AuntificationUser(txLogin.Text, txPassword.Text);
            MessageBox.Show("Добро пожаловать" + " " + user.Name);
            View.WindowMenu windowMenu = new View.WindowMenu();
            windowMenu.Show();
            this.Close();
        }

        
    }
    public class Auntification
    {
        public static DB.User AuntificationUser(string login, string password)
        {
            try
            {
                DB.TsaplinEntities6 entities = new DB.TsaplinEntities6();
                var user = entities.User.Single(x => x.Login == login && x.Password == password);
                return user;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }

}

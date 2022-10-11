using gabrielspetillo_d7_avaliacao.Data;
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

namespace gabrielspetillo_d7_avaliacao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        UserData user = new();

        public static Visibility gridBackground = Visibility.Hidden;

        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userList = context.Users.ToList();
            foreach (UserData userData in userList)
            {
                if(user.Email == userData.Email && user.Password == userData.Password)
                {
                    GridLoginSuccess.Visibility = Visibility.Visible;
                    return;
                }
            }
            GridLoginFail.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}

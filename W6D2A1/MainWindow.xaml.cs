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
using BookRepository;

namespace W6D2A1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Login newLogin; //calling class and giving a variable
        public MainWindow()
        {
            InitializeComponent();
            newLogin = new Login(); //publicizing the variable
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(newLogin.loggingin(txtUserName.Text, pwBox.Password))
            {
                Library window = new Library(); //calling the next window
                window.Show();//Window showing
                this.Close(); //if password is enterred correctly, window will close
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username"); //displaying message box if information is incorrect
                txtUserName.Clear(); //clearing out what was enterred
                pwBox.Clear();
            }

        }
    }
}

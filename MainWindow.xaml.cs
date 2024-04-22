using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_AssignPasswordLoginForm_Arevalo
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

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Password;

            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            
            if (userName == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Password;

            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            
            MessageBox.Show("Registration successful!");
        }
    }
}
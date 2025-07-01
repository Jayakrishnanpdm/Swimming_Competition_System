using System;
using System.Windows;
using System.Windows.Controls;

namespace Swimmingpool_competition
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

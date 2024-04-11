using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopManagement.controller;
using ShopManagement.model.User;

namespace ShopManagement.view.Login
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string role = comboBox_Role.SelectedItem.ToString();

            UserModel user = new UserModel( username, password, role); 
            user.Username = username;
            user.Password = password; // Remember security concerns of storing plain text passwords
            user.Role = role;

            Console.WriteLine(username);
            Console.WriteLine(password);
            Console.WriteLine(role);
            //UserModel user1 = new UserModel("test_user", "test_password", "admin"); // Remember password security

            if (userController.SignUp(user))
            {
                this.Controls.Clear();
                UserControl LoginView = new Login();
                this.Controls.Add(LoginView);
                LoginView.Show();
            }

            // Handle response from UserController
        }

    }
}

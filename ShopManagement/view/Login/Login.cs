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
using ShopManagement.view.Shop;

namespace ShopManagement.view.Login
{
    public partial class Login : UserControl
    {
        public UserModel userData = new UserModel();
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl SignUpView = new SignUp();
            this.Controls.Add(SignUpView);
            SignUpView.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            string username = textBox1.Text;
            string password = textBox2.Text;

            Console.WriteLine(username);
            Console.WriteLine(password);

            UserModel user = userController.SignIn(username, password);
            if (user != null)
            {
                userData = new UserModel(user.IDUSER, user.IDSHOP,user.Username, user.Password, user.Role);
                if (user.Role == "ADMIN")
                {
                    this.Controls.Clear();
                    UserControl ShopsViewAdmin = new ShopAdmin();
                    this.Controls.Add(ShopsViewAdmin);
                    ShopsViewAdmin.Show();
                }
                else if (user.Role == "GERANT" || user.Role == "STAFF")
                {
                    this.Controls.Clear();
                    UserControl ShopsView = new ShopPlatform(userData);
                    this.Controls.Add(ShopsView);
                    ShopsView.Show();
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

        }
    }
}

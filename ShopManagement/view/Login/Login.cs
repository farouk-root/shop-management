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
        public Login()
        {
            InitializeComponent();
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
                Console.WriteLine(user.ToString());
                Console.WriteLine(user.IDSHOP);
                if (user.Role == "ADMIN")
                {
                    this.Controls.Clear();
                    UserControl ShopsViewAdmin = new ShopAdmin();
                    this.Controls.Add(ShopsViewAdmin);
                    ShopsViewAdmin.Show();
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

        }
    }
}

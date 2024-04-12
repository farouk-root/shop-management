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
using ShopManagement.model.Shop;

namespace ShopManagement.view.Login
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
            FillShopComboBox(); // Call method on initialization
            comboBox_Role.SelectedIndex = 2;
            comboBox_Shops.SelectedIndex = 0;
            textBox_password.PasswordChar = '*';
        }
        private void FillShopComboBox()
        {
            ShopController shopController = new ShopController();

            List<ShopModel> shops = shopController.GetAllShops();

            comboBox_Shops.Items.Clear();

            foreach (ShopModel shop in shops)
            {
                comboBox_Shops.Items.Add(shop.NAMESHOP); // Assuming ShopModel has a Name property
            }
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

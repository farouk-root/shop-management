using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopManagement.view.Login;

namespace ShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicPanel.Controls.Clear();
            UserControl LoginView = new Login();
            BasicPanel.Controls.Add(LoginView);
            LoginView.Show();
        }
    }
}

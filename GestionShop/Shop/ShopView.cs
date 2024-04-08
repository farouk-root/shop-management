using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionShop.Model.Shop;
using GestionShop.Controller;
using System.Text.RegularExpressions;

namespace GestionShop.Shop
{
    public partial class ShopView : UserControl
    {
        private ShopController shopController = new ShopController();
        private List<ShopModel> shops = new List<ShopModel>(); // Store retrieved shops

        private int ID = -1;
        private string nom = "";
        private string localisation = "";
        private string phoneNum = "";

        public ShopView()
        {
            InitializeComponent();
            LoadShops(); // Retrieve and display shops on form load
        }

        // ... other methods

        private void LoadShops()
        {
            try
            {
                shops = shopController.GetShops();
                BindShopsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching shops: " + ex.Message, "Error");
            }
        }

        private void BindShopsToGrid()
        {
            if (shops != null)
            {
                dataGridView1.DataSource = shops; // Bind shops to the grid
            }
            else
            {
                MessageBox.Show("No shops found!", "Information");
            }
        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            string id = text_idShop.Text;
            string name = text_NomShop.Text.Trim();
            string location = text_localisation.Text.Trim();
            string phone = text_phone.Text.Trim();

            bool isValid = true;
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
                errorMessage.AppendLine("Name is required.");
            }

            if (string.IsNullOrEmpty(location))
            {
                isValid = false;
                errorMessage.AppendLine("Location is required.");
            }

            // Phone number validation (only numbers)
            if (string.IsNullOrEmpty(phone))
            {
                isValid = false;
                errorMessage.AppendLine("Phone number is required.");
            }
            else if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                isValid = false;
                errorMessage.AppendLine("Phone number must contain only digits (0-9).");
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShopModel newShop = new ShopModel(int.Parse(id), name, location, phone);
            Console.WriteLine("New Shop Details:");
            Console.WriteLine(newShop.ToString());
            try
            {
                shopController.CreateShop(newShop);
                MessageBox.Show("Shop created successfully!", "Success");
                text_NomShop.Text = "";
                text_localisation.Text = "";
                text_phone.Text = "";
                LoadShops(); // Refresh data grid after creation
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating shop: " + ex.Message, "Error");
            }
        }

        private void ShowShops_Click(object sender, EventArgs e)
        {
            shops = shopController.GetShops();
            foreach (ShopModel shop in shops)
            {
                Console.WriteLine(shop.ToString()); // Use the existing ToString method
            }
        }


        private void UpdateShopButton_Click(object sender, EventArgs e)
        {
                        // Get data from textboxes
            string id = text_idShop.Text;
            string name = text_NomShop.Text;
            string location = text_localisation.Text;
            string phone = text_phone.Text;

            // Basic validation (optional)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a Shop model object
            ShopModel newShop = new ShopModel
            (
            int.Parse(id),
            name,
               location,
                phone
            );

            // Print the newShop object details to console
            Console.WriteLine("New Shop Details:");
            Console.WriteLine(newShop.ToString());
            try
            {
                // Use the ShopController to create the shop
                if (this.ID != int.Parse(id) || this.nom != name || this.localisation != location || this.phoneNum != phone)
                {
                    shopController.UpdateShop(int.Parse(id), newShop);
                    MessageBox.Show("Shop updated successfully!", "Success");
                }

                // Clear input fields (optional)
                text_NomShop.Text = "";
                text_localisation.Text = "";
                text_phone.Text = "";

                LoadShops();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating shop: " + ex.Message, "Error");
            }
        }

        private void getShopData_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Get the selected row
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Retrieve attributes assuming same indices as in CellClick_1 method
                    int ID = int.Parse(selectedRow.Cells[0].Value.ToString());
                    string nom = selectedRow.Cells[1].Value.ToString();
                    string localisation = selectedRow.Cells[2].Value.ToString();
                    string phoneNum = selectedRow.Cells[3].Value.ToString();

                    Console.WriteLine(nom);

                    // Populate textboxes (adjust control names if different)
                    text_idShop.Text = ID.ToString();
                    text_NomShop.Text = nom;
                    text_localisation.Text = localisation;
                    text_phone.Text = phoneNum;
                }


            }
            catch (Exception ex)
            {
                // Handle potential errors (e.g., invalid cell value, index out of bounds)
                MessageBox.Show("Error retrieving attributes: " + ex.Message);
            }
        }

        private void DeleteShopButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the ID of the shop to be deleted (adjust based on your UI)
                int id = int.Parse(text_idShop.Text);  // Assuming you have a text box to display the ID

                // Call the DeleteShop function in your controller to perform the deletion
                shopController.DeleteShop(id);  // Replace 'controller' with your actual controller instance

                // Display a success message
                MessageBox.Show("Shop deleted successfully.");
                LoadShops();  // Or clear relevant fields
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during deletion
                MessageBox.Show("Error deleting shop: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       








    }
}

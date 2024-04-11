using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopManagement.model.Shop;
using ShopManagement.utils;
using System.Data.OleDb;


namespace ShopManagement.controller
{
    class ShopController
    {
        public List<ShopModel> GetAllShops()
        {
            List<ShopModel> shops = new List<ShopModel>();

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM SHOP";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idShop = Convert.ToInt64(reader["IDSHOP"]);
                            string nameShop = reader["NAMESHOP"].ToString();
                            string locationShop = reader["LOCATIONSHOP"].ToString();
                            string phoneShop = reader["PHONESHOP"].ToString();

                            ShopModel shop = new ShopModel(idShop, nameShop, locationShop, phoneShop);
                            shops.Add(shop);
                        }
                    }
                }
            }

            return shops;
        }

        public bool AddShop(ShopModel shop)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string insertQuery = "INSERT INTO SHOP (NAMESHOP, LOCATIONSHOP, PHONESHOP) VALUES (@NameShop, @LocationShop, @PhoneShop)";
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@NameShop", shop.NAMESHOP);
                    command.Parameters.AddWithValue("@LocationShop", shop.LOCATIONSHOP);
                    command.Parameters.AddWithValue("@PhoneShop", shop.PHONESHOP);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (newly inserted shop)
                }
            }

            return successful;
        }

        public bool UpdateShop(ShopModel shop)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string updateQuery = "UPDATE SHOP SET NAMESHOP = @NameShop, LOCATIONSHOP = @LocationShop, PHONESHOP = @PhoneShop WHERE IDSHOP = @IDSHOP";
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@NameShop", shop.NAMESHOP);
                    command.Parameters.AddWithValue("@LocationShop", shop.LOCATIONSHOP);
                    command.Parameters.AddWithValue("@PhoneShop", shop.PHONESHOP);
                    command.Parameters.AddWithValue("@IDSHOP", shop.IDSHOP);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (updated shop)
                }
            }

            return successful;
        }

        public bool DeleteShop(long shopID)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM SHOP WHERE IDSHOP = @IDSHOP";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDSHOP", shopID);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (deleted shop)
                }
            }

            return successful;
        }
        public List<ShopModel> SearchShops(string criteria, string searchText)
        {
            List<ShopModel> shops = new List<ShopModel>();

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string searchQuery;

                switch (criteria)
                {
                    case "NameShop":
                        searchQuery = "SELECT * FROM SHOP WHERE NAMESHOP LIKE @SearchText"; // Add wildcards for partial matches
                        break;
                    case "Location":
                        searchQuery = "SELECT * FROM SHOP WHERE LOCATIONSHOP LIKE @SearchText";
                        break;
                    case "Phone":
                        searchQuery = "SELECT * FROM SHOP WHERE PHONESHOP LIKE @SearchText";
                        break;
                    default:
                        searchQuery = "SELECT * FROM SHOP"; // Return all shops if criteria is invalid
                        break;
                }

                Console.WriteLine(searchQuery); // For debugging (optional)

                using (OleDbCommand command = new OleDbCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                long idShop = Convert.ToInt64(reader["IDSHOP"]);
                                string nameShop = reader["NAMESHOP"].ToString();
                                string locationShop = reader["LOCATIONSHOP"].ToString();
                                string phoneShop = reader["PHONESHOP"].ToString();

                                ShopModel shop = new ShopModel(idShop, nameShop, locationShop, phoneShop);
                                Console.WriteLine(shop.NAMESHOP); // For debugging (optional)
                                shops.Add(shop);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found"); // Informative message (optional)
                        }
                    }
                }
            }

            return shops;
        }

        public ShopModel GetShopByID(long shopID)
        {
            ShopModel shop = null;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM SHOP WHERE IDSHOP = @IDSHOP";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDSHOP", shopID);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            long idShop = Convert.ToInt64(reader["IDSHOP"]);
                            string nameShop = reader["NAMESHOP"].ToString();
                            string locationShop = reader["LOCATIONSHOP"].ToString();
                            string phoneShop = reader["PHONESHOP"].ToString();

                            shop = new ShopModel(idShop, nameShop, locationShop, phoneShop);
                        }
                    }
                }
            }

            return shop;
        }


    }
}

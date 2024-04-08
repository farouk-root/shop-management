using System.Collections.Generic;
using GestionShop.Model.Shop;
using System.Data.OleDb;
using GestionShop.Utils;
using System;

namespace GestionShop.Controller
{
    public class ShopController
    {

        public List<ShopModel> GetShops()
        {
            List<ShopModel> shops = new List<ShopModel>();
            using (OleDbConnection con = connection.GetConnection())
            {
                con.Open();
                string selectQuery = "SELECT * FROM SHOP";
                using (OleDbCommand command = new OleDbCommand(selectQuery, con))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shops.Add(new ShopModel
                            (
                                 int.Parse(reader["IDSHOP"].ToString()),
                                 reader["NAMESHOP"].ToString(),
                                reader["LOCATIONSHOP"].ToString(),
                                reader["PHONESHOP"].ToString()
                            ));
                        }
                    }
                }
            }
            return shops;
        }

        public void CreateShop(ShopModel shop)
        {
            using (OleDbConnection con = connection.GetConnection())
            {
                con.Open();
                string insertQuery = "INSERT INTO SHOP (IDSHOP,NAMESHOP, LOCATIONSHOP, PHONESHOP) VALUES (@id,@name, @location, @phone)";
                using (OleDbCommand command = new OleDbCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@id", shop.IDShop);
                    command.Parameters.AddWithValue("@name", shop.NameShop);
                    command.Parameters.AddWithValue("@location", shop.LocationShop);
                    command.Parameters.AddWithValue("@phone", shop.PhoneShop); // Number conversion handled by OleDb
                    command.ExecuteNonQuery();
                }
            }
        }


        // Similar methods for UpdateShop and DeleteShop
        public void UpdateShop(int id, ShopModel shop)
        {
            using (OleDbConnection con = connection.GetConnection())
            {
                con.Open();
                string updateQuery = "UPDATE SHOP SET NAMESHOP = @name, LOCATIONSHOP = @location, PHONESHOP = @phone WHERE IDSHOP = @id";
                //string updateQuery = "UPDATE SHOP SET NAMESHOP = @name WHERE IDSHOP = @id";
                using (OleDbCommand command = new OleDbCommand(updateQuery, con))
                {
                    
                    command.Parameters.AddWithValue("@name", shop.NameShop);
                    command.Parameters.AddWithValue("@location", shop.LocationShop);
                    command.Parameters.AddWithValue("@phone", shop.PhoneShop);
                    command.Parameters.AddWithValue("@id", id);                    
                    int x = command.ExecuteNonQuery();
                    Console.WriteLine(x);
                }
            }
        }

        public void DeleteShop(int id)
        {
            using (OleDbConnection con = connection.GetConnection())
            {
                con.Open();
                string deleteQuery = "DELETE FROM SHOP WHERE IDSHOP = @id";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

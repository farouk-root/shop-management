using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopManagement.model.User;
using ShopManagement.utils;
using System.Data.OleDb;

namespace ShopManagement.controller
{
    class UserController
    {
        public Boolean SignUp(UserModel user)
        {
            long idShop = 1;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                //string insertQuery = "INSERT INTO SHOPUSER(ID,IDSHOP,[USERNAME], [PASSWORD], [ROLE]) VALUES(@Id,@IdShop,@Username, @Password, @Role)";
                string insertQuery = "INSERT INTO SHOPUSER(IDSHOP,[USERNAME], [PASSWORD], [ROLE]) VALUES(@IdShop,@Username, @Password, @Role)";
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdShop", idShop);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);

                    command.ExecuteNonQuery();
                }
            }
            return true;

            
        }

        public UserModel SignIn(string username, string password)
        {
            UserModel user = null; // Initialize to null

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM SHOPUSER WHERE [USERNAME] = @Username AND [PASSWORD] = @Password";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    // Hash the password before adding it to the parameter (replace with secure hashing)
                    command.Parameters.AddWithValue("@Password", password); // Implement HashPassword method

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); 
                            user = new UserModel( 
                               Convert.ToInt64(reader["ID"]),
                               Convert.ToInt64(reader["IDSHOP"]),
                              reader["USERNAME"].ToString(),
                              reader["PASSWORD"].ToString(),
                              reader["ROLE"].ToString()
                            );
                        }
                    }
                }
            }

            return user;
        }


    }
}

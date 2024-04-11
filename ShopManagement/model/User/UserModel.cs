using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopManagement.model.User
{
    class UserModel
    {
        public long IDUSER { get; set; }
        public long IDSHOP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserModel(){}


        public UserModel(long iduser, string username, string password, string role)
        {
            this.IDUSER = iduser;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public UserModel(long iduser,long idshop, string username, string password, string role)
        {
            this.IDUSER = iduser;
            this.IDSHOP = idshop;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public UserModel(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public override string ToString() // Override ToString method
        {
            return string.Format("Username: {0}, Role: {1}", Username, Role);
        }




    }
}

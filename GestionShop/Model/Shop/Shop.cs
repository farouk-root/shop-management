using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionShop.Model.Shop
{
    public class ShopModel
    {
        public int IDShop { get; set; }
        public string NameShop { get; set; }
        public string LocationShop { get; set; }
        public string PhoneShop { get; set; }

        public ShopModel(string nameShop, string locationShop, string phoneShop) // New constructor without IDShop
        {
            NameShop = nameShop;
            LocationShop = locationShop;
            PhoneShop = phoneShop;
        }
        public ShopModel(int idShop, string nameShop, string locationShop, string phoneShop) // New constructor with all args
        {
            IDShop = idShop;
            NameShop = nameShop;
            LocationShop = locationShop;
            PhoneShop = phoneShop;
        }

    public override string ToString()
    {
        return "ID: " + IDShop + ", Name: " + NameShop +
                       ", Location: " + LocationShop + ", Phone: " + PhoneShop; 
    }
    }
}

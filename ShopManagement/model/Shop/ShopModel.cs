using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopManagement.model.Shop
{
    public class ShopModel
    {
        public long IDSHOP { get; set; }
        public string NAMESHOP { get; set; }
        public string LOCATIONSHOP { get; set; }
        public string PHONESHOP { get; set; }

        // Empty constructor
        public ShopModel() { }

        // Constructor with all properties
        public ShopModel(long idshop, string nameshop, string locationshop, string phoneshop)
        {
            this.IDSHOP = idshop;
            this.NAMESHOP = nameshop;
            this.LOCATIONSHOP = locationshop;
            this.PHONESHOP = phoneshop;
        }

        public ShopModel(string nameshop, string locationshop, string phoneshop)
        {
            this.NAMESHOP = nameshop;
            this.LOCATIONSHOP = locationshop;
            this.PHONESHOP = phoneshop;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Location: {2}, Phone: {3}", IDSHOP, NAMESHOP, LOCATIONSHOP, PHONESHOP);
        }
    }
}

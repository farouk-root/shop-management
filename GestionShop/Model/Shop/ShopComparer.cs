using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionShop.Model.Shop
{
    public class ShopComparer : IComparer<ShopModel>
    {
        private int sortColumnIndex;
        private bool sortAscending;

        public ShopComparer(int columnIndex, bool ascending)
        {
            sortColumnIndex = columnIndex;
            sortAscending = ascending;
        }

        public int Compare(ShopModel x, ShopModel y)
        {
            switch (sortColumnIndex)
            {
                case 0: // Sort by ID
                    return sortAscending ? x.IDShop.CompareTo(y.IDShop) : y.IDShop.CompareTo(x.IDShop);
                case 1: // Sort by Name
                    return sortAscending ? string.Compare(x.NameShop, y.NameShop) : string.Compare(y.NameShop, x.NameShop);
                case 2: // Sort by Location
                    return sortAscending ? string.Compare(x.LocationShop, y.LocationShop) : string.Compare(y.LocationShop, x.LocationShop);
                // ... Add cases for other columns
                default:
                    return 0;
            }
        }
    }

}

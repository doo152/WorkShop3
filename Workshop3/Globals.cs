using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace Workshop3
{
    public static class Global
    {
        public static List<Package> packages;
        public static List<Product> Products;
        public static List<PkgProductsSuppliers> productsSuppliers;
        public static List<Supplier> suppliers;
        public static int indexToEdit = -1;
    }
}

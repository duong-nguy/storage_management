using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend
{
    static class Product_factory
    {
        public static abstractions.PRODUCT create_product(
            string id,
            enums.Product_types type,
            enums.Manufacturers manufacturer,
            string model,
            string quantity,
            params string[] args)
        {
            throw new Exception();
        }
        public static List<string> get_product_properties(enums.Product_types type)
        {
            throw new Exception();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.abstractions
{
    static class Product_factory
    {
        public PRODUCT create_product(
            string id,
            Type_of_product type,
            string manufacturer,
            string model,
            string quantity,
            params string[] args)
        {
            switch (type)
            {
                default:
                    break;
            }
        }
    }
}

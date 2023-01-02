using store_management.backend.abstractions;
using store_management.enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend
{
    static class Database
    {
        static Dictionary<string, PRODUCT> database;
        static Random random;
        static public void add_product(
            Product_types type,
            Manufacturers manufacturer,
            string model,
            int quantity,
            Image image,
            params string[] args)
        {
            string id = create_id(type,manufacturer);
            throw new Exception();
        }

        static public string create_id(
            Product_types type,
            Manufacturers manufacturer)
        {
            //TT-MM-NNNNN
            //T = type, M = manufacturer, N = Rand nums
            
            string id = $"{type} - {manufacturer} - {random.Next(1111, 9999)}";
            while (database.ContainsKey(id))
            {
                id = $"{type} - {manufacturer} - {random.Next(1111, 9999)}";

            }
            return id;
        }

        static public void database_init()
        {
            if (!Directory.Exists(@"./database"))
            {
                Directory.CreateDirectory(@"./database");
                Directory.CreateDirectory(@"./database/images");
                File.Create(@"./database/data");
            }
        }
        static public List<string> get_product_properties(Product_types type)
        {
            return Product_factory.get_product_properties(type);
        }
        static public void delete_product(string id)
        {
            throw new NotImplementedException();
        }

        static public Dictionary<string, Dictionary<PRODUCT, Image>>
            search(string keywords, Search search)
        {
            throw new NotImplementedException();
        }
    }
}

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
            image.Save($@"./database/images/{id}");
            Object product = Product_factory.create_product(id, type, manufacturer, model, quantity, args);
            switch (type)
            {
                // convert and add product to database
            }
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
            database.Remove(id);
            //remove from drive
        }

        static public Dictionary<string, Dictionary<PRODUCT, Image>>
            search(string keywords, Search search)
        {
            throw new NotImplementedException();
        }
        private static void save_product(PRODUCT PRODUCT)
        {
            FileStream fs = new FileStream(
                @"./database/data",
                FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            switch (PRODUCT.type)
            {
                //cast PRODUCT to it type
                //sw.WriteLine(product.toString());
                // write it to drive
            }
            sw.Close();
            fs.Close();
        }
        private static void remove_from_drive(string id)
        {
            FileStream fs = new FileStream(
                @"./database/data",
                FileMode.Open, FileAccess.ReadWrite
                );
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                if (sr.ReadLine().Split(',')[0] == id) sw.WriteLine("");
            }
            sr.Close();
            sw.Close();
            fs.Close();
        }
        private static void load_up()
        {
            FileStream fs = new FileStream(
            @"./database/data",
            FileMode.Open, FileAccess.ReadWrite
            );
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                PRODUCT product = Product_factory.create_product(sr.ReadLine().Split(','));
                database.Add(product.id, product);
            }
            sr.Close();
            fs.Close();
        }
    
    }
}

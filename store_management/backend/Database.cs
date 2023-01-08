using store_management.backend.abstractions;
using store_management.enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
            string id = create_id(type, manufacturer);
            PRODUCT product = Product_factory.create_product(id, type, manufacturer, model, quantity, args);
            database.Add(id, product);
            save_product(product, image);
        }

        static public string create_id(
            Product_types type,
            Manufacturers manufacturer)
        {
            string id = $"{(int)type}-{(int)manufacturer}-{random.Next(1111, 9999)}";
            while (database.ContainsKey(id))
            {
                id = $"{(int)type}-{(int)manufacturer}-{random.Next(1111, 9999)}";

            }
            return id;
        }


        static public void database_init()
        {
           
            database = new Dictionary<string, PRODUCT>();
            random = new Random();
            if (!Directory.Exists(@"./database"))
            {
                Directory.CreateDirectory(@"./database");
                Directory.CreateDirectory(@"./database/images");
                File.Create(@"./database/data.txt").Close();
                
            }
            load_up();
        }
        static public Dictionary<string, string> get_product_properties(Product_types type)
        {
            return Product_factory.get_product_properties(type);
        }
        static public void delete_product(string id)
        {
            database.Remove(id);
            remove_from_drive(id);
            
        }

        static public List<PRODUCT> search(
            string keywords, Search search,
            Product_types type = Product_types.null_value)
        {
            List<PRODUCT> res = new List<PRODUCT>();
            if (search == Search.by_id && database.ContainsKey(keywords))
            {
                res.Add(database[keywords]);
                return res;
            }
            keywords = Utility.make_usable_string(keywords);
            foreach (KeyValuePair<string, PRODUCT> keyValue in database)
            {
                if (type == Product_types.null_value)
                {
                    switch (search)
                    {
                        case Search.by_model:
                            if (keyValue.Value.model
                                == keywords)
                                res.Add(keyValue.Value);
                            break;
                        case Search.by_manufacturer:
                            if (keyValue.Value.manufacturer.ToString()
                                == keywords)
                                res.Add(keyValue.Value);
                            break;
                    }
                }
                else
                {
                    if (keyValue.Value.type == type)
                    {
                        switch (search)
                        {
                            case Search.by_model:
                                if (keyValue.Value.model
                                    == keywords)
                                    res.Add(keyValue.Value);
                                break;
                            case Search.by_manufacturer:
                                if (keyValue.Value.manufacturer.ToString()
                                    == keywords)
                                    res.Add(keyValue.Value);
                                break;
                            default:
                                res.Add(keyValue.Value);
                                break;
                        }
                    }
                }
                
            }
            return res;
        }
        static public List<PRODUCT> get_all_product()
        {
            return database.Values.ToList();
        }
        static public Image get_image(string id)
        {
            return Image.FromFile($@"./database/images/{id}.jpg");
        }

        private static void save_product(PRODUCT PRODUCT, Image image)
        {
            image.Save($@"./database/images/{PRODUCT.id}.jpg");
            FileStream fs = new FileStream(
                @"./database/data.txt",
                FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(PRODUCT.ToString());
            sw.Close();
            fs.Close();

            
        }
        private static void remove_from_drive(string id)
        {
            List<string> file = File.ReadAllLines(@"./database/data.txt").ToList();
            string remove = "";
            foreach (string line in file)
            {
                remove = line.Split(',')[0] == id ? line : "";
            }
            file.Remove(remove);
            
            File.Delete($@"./database/images/{id}.jpg");
            File.WriteAllLines(@"./database/data.txt", file.ToArray());
            
        }
        private static void load_up()
        {
            FileStream fs = new FileStream(
            @"./database/data.txt",
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

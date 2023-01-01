using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend
{
    class Database : abstractions.DATABASE
    {
        Dictionary<string, abstractions.PRODUCT> database;
        Random random;
        public Database()
        {
            database_init();
            random = new Random();
        }
        public void add_product(
            string type, string manufacturer,
            string model, int quantity, params string[] args)
        {
            string id = create_id(model);
        }

        public string create_id(string model)
        {
            char[] model_c = model.ToArray();
            string id = model_c[0] + model_c[1] + random.Next(1111, 9999).ToString();
            while (database.ContainsKey(id))
            {
                id = model_c[0] + model_c[1] + random.Next(1111, 9999).ToString();

            }
            return id;
        }

        public void database_init()
        {
            if (!Directory.Exists(@"./database"))
            {
                Directory.CreateDirectory(@"./database");
                Directory.CreateDirectory(@"./database/images");
                File.Create(@"./database/data");
            }
        }

        public void delete_product(string id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Image> search(
            string keywords, bool by_type = false,
            bool by_id = false, bool by_manufacturer = false)//enum this
        {
            throw new NotImplementedException();
        }
    }
}

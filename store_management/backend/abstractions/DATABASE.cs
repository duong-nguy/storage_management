using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace store_management.backend.abstractions
{
    interface DATABASE
    {
        void database_init();
        void add_product(
            string type,
            string manufacturer,
            string model,
            int quantity,
            params string[] args );
        Dictionary<string,Image> search(
            string keywords,
            bool by_type = false,
            bool by_id = false,
            bool by_manufacturer = false);
        string create_id(string model);
        void delete_product(string id);
    }
}

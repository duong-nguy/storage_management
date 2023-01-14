using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Androids : abstractions.PRODUCT
    {
        public Androids(string id,
            Product_types type, Manufacturers manufacturer,
            string model, int quantity, string occupation,
            int atk,int def, int speed)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;

            this.occupation = occupation;
            this.atk = atk;
            this.def = def;
            this.speed = speed;
        }

        public override string id { get; }

        public override Product_types type { get; }


        public override Manufacturers manufacturer { get; }

        public override string model
        {
            get;
        }

        public override int quantity
        {
            get;
        }
        
        public string occupation
        {
            get;
        }
        public int atk
        {
            get;
        }
        public int def
        {
            get;
        }
        public int speed
        {
            get;
        }


        public override Dictionary<string, string> full_description()
        {
            Dictionary<string, string> full_description = new Dictionary<string, string>();
            full_description.Add("Id", id);
            full_description.Add("Type",
               Utility.make_pretty_string(type.ToString()));
            full_description.Add("Manufacturer",
                Utility.make_pretty_string(manufacturer.ToString()));
            full_description.Add("Model", model);
            full_description.Add("Quantity", quantity.ToString());
            full_description.Add("Occupation", occupation);
            full_description.Add("ATK", atk.ToString());
            full_description.Add("DEF", def.ToString());
            full_description.Add("Speed", speed.ToString());
            return full_description;
        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Occupation", "string");
            properties.Add("ATK", "int");
            properties.Add("DEF", "int");
            properties.Add("Speed", "int");

            return properties;
        }
        public override string ToString()
        {
            return $"{id},{(int)type},{(int)manufacturer},{model},{quantity}" +
                $",{occupation},{atk},{def}," +
                $"{speed}";
        }
        public override string get_string_data()
        {
            return $"{id},{type},{manufacturer},{model},quantity={quantity}" +
                $",occupation={occupation},atk={atk},def={def}," +
                $"speed={speed}";
        }

    }
}

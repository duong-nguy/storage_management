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
            int bust,int weist, int hip)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;

            this.occupation = occupation;
            this.bust = bust;
            this.weist = weist;
            this.hip = hip;
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
        public int bust
        {
            get;
        }
        public int weist
        {
            get;
        }
        public int hip
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
            full_description.Add("Bust", bust.ToString());
            full_description.Add("Weist", weist.ToString());
            full_description.Add("Hip", hip.ToString());
            return full_description;
        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Occupation", "string");
            properties.Add("Bust", "int");
            properties.Add("Weist", "int");
            properties.Add("Hip", "int");

            return properties;
        }
        public override string ToString()
        {
            return $"{id},{(int)type},{(int)manufacturer},{model},{quantity}" +
                $",{occupation},{bust},{weist}," +
                $"{hip}";
        }
        public override string get_string_data()
        {
            return $"{id},{type},{manufacturer},{model},quantity:{quantity}" +
                $",occupation:{occupation},bust:{bust},weist:{weist}," +
                $"hip:{hip}";
        }

    }
}

using store_management.enums;
using System;
using System.Collections.Generic;

namespace store_management.backend.Products
{
    class Drones : abstractions.PRODUCT
    {

        public Drones(
            string id, Product_types type, Manufacturers manufacturer,
            string model, int quantity, string roles, int speed, 
            int range, bool autonomous)
        {
            this.id=id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.roles = roles;
            this.speed=speed;
            this.range = range;
            this.autonomous = autonomous;
        }


        public override string id 
        {
            get;
        }
        // implementation example it just need to return the id
        // public override string id { get; }
        // same as the other

        // when you are here goto enums.Product_types file
        public override Product_types type
        {
            get;
        }

        // when you are here goto enums.Manufacturers file  

        public override Manufacturers manufacturer
        {
            get;
        }

        public override string model
        {
            get;
        }

        public override int quantity {
            get;
        }

        // you can change the name and return type of these field
        public  bool autonomous {
            get;
        }
        public int range {
            get;
        }
        public string roles
        {
            get;
        }
        public int speed {
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
            full_description.Add("Model",model);
            full_description.Add("Quantity",quantity.ToString());
            full_description.Add("Roles", roles);
            full_description.Add("Speed", speed.ToString());
            full_description.Add("Range", range.ToString());
            full_description.Add("Autonomous", autonomous.ToString());
            return full_description;

        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Roles", "string");
            properties.Add("Speed", "int");
            properties.Add("Range", "int");
            properties.Add("Autonomous", "bool");

            return properties;

        }

        public override string ToString()
        {
            return $"{id},{(int)type},{(int)manufacturer}, {model}," +
                $"{quantity},{roles},{speed},{range},{autonomous}";
        
        }

    }
}

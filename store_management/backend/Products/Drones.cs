using store_management.enums;
using System;
using System.Collections.Generic;

namespace store_management.backend.Products
{
    class Drones : abstractions.PRODUCT
    {

        public Drones(
            string id, Product_types type, Manufacturers manufacturer,
            string model, int quantity, int speed, string specialization,
            int range, bool autonomous)
        {
            this.id=id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.speed=speed;
            this.specialization = specialization;
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
        public string specialization
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
            full_description.Add("model",model);
            full_description.Add("quantity",quantity.ToString());
            full_description.Add("Type", type.ToString());
            full_description.Add("Manufacturer", manufacturer.ToString());
            full_description.Add("Speed", speed.ToString());
            full_description.Add("specialization", specialization);
            full_description.Add("range", range.ToString());
            full_description.Add("autonomous", autonomous.ToString());
            return full_description;

        }

        public override Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Speed", speed.ToString());
            properties.Add("specialization", specialization);
            properties.Add("range", range.ToString());
            properties.Add("autonomous", autonomous.ToString());

            return properties;

        }

        public string ToString(string format)
        {
            return id + "," + manufacturer + ","
                + model + "," + type + "," + quantity + ","
                + speed.ToString() + "," + specialization + ","
                + range.ToString() + "," + autonomous.ToString();
        }

    }
}

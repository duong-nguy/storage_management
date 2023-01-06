using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Space_Guns : abstractions.PRODUCT
    {

        // implement everythings that have throw new NotImplementedException();
        public Space_Guns(
            string id, Product_types type, Manufacturers manufacturer,
            string model, int quantity, int damage,
            int weight, int cost, int rounds)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.damage = damage;
            this.weight=weight;
            this.cost = cost; 
            this.rounds=rounds;
        }


        public override string id
        {

            get;
        }

        public override Product_types type
        {

            get;
        }


        public override Manufacturers manufacturer
        {

            get;
        }

        public override int quantity
        {

            get;
        }
        public override string model
        {

            get;
        }

        // you can change the name and return type of these field
        public int damage
        {

            get;
        }
        public int weight
        {

            get;
        }
        public int cost
        {

            get;
        }
        public int rounds
        {

            get;
        }

        public override Dictionary<string, string> full_description()
        {
            Dictionary<string, string> full_description = new Dictionary<string, string>();
            full_description.Add("Id", id);
            full_description.Add("Type", type.ToString());
            full_description.Add("Manufacturer", manufacturer.ToString());
            full_description.Add("Model", model);
            full_description.Add("Quantity", quantity.ToString());
            full_description.Add("Damage", damage.ToString());
            full_description.Add("Wieght", weight.ToString());
            full_description.Add("Cost", cost.ToString());
            full_description.Add("Rounds", rounds.ToString());
            return full_description;

        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Damage", "int");
            properties.Add("Wieght", "int");
            properties.Add("Cost", "int");
            properties.Add("Rounds", "int");
            return properties;

        }

        public override string ToString()
        {
            string format =
                id + "," + type.ToString() + "," + manufacturer.ToString() +
                "," + model + ","  + quantity.ToString() +
                "," + damage.ToString() + "," + weight.ToString() +
                "," + cost.ToString() + "," + rounds.ToString();
            return format;
        }
        
    }
}

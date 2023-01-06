using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Space_Gun : abstractions.PRODUCT
    {
        string ID;
        string MANUFACTURER = Manufacturers.Back_from_furture.ToString();
        string TYPE = enums.Product_types.Space_gun.ToString();
        string MODEL;
        string QUANTITY;
        string Damage;
        string WEIGHT;
        string COST;
        string ROUNDS;
        // implement everythings that have throw new NotImplementedException();
        public Space_Gun(string id, string damage, string manufacturer, string type, string model, string quantity, string weight, string cost, string rounds)
        {
            this.ID = id;
            this.MANUFACTURER = manufacturer;
            this.TYPE = type;
            this.MODEL = model;
            this.QUANTITY = quantity;
            this.Damage = damage;
            this.WEIGHT=weight;
            this.COST = cost; 
            this.ROUNDS=rounds;
            throw new NotImplementedException();
        }


        public override string id
        {

            get
            {
                return ID;
                throw new NotImplementedException();
            }
        }
        // implementation example it just need to return the id
        // public override string id { get; }
        // same as the other

        // when you are here goto enums.Product_types file
        public override Product_types type
        {

            get
            {
                return enums.Product_types.Space_gun;
                throw new NotImplementedException();
            }
        }

        // when you are here goto enums.Manufacturers file
        public override Manufacturers manufacturer
        {

            get
            {
                return enums.Manufacturers.Back_from_furture;
                throw new NotImplementedException();
            }
        }

        public override string quantity
        {

            get
            {
                return QUANTITY;
                throw new NotImplementedException();
            }
        }
        public override string model
        {

            get
            {
                return MODEL;
                throw new NotImplementedException();
            }
        }

        // you can change the name and return type of these field
        public string damage
        {

            get
            {
                return Damage;
                throw new NotImplementedException();
            }
        }
        public string weight
        {

            get
            {
                return WEIGHT;
                throw new NotImplementedException();
            }
        }
        public string cost
        {

            get
            {
                return COST;
                throw new NotImplementedException();
            }
        }
        public string rounds
        {

            get
            {
                return ROUNDS;
                throw new NotImplementedException();
            }
        }

        public override Dictionary<string, string> full_description()
        {
            full_description().Add("Id", id);
            full_description().Add("model", model);
            full_description().Add("quantity", quantity);
            full_description().Add("Transformers", enums.Product_types.Spider_Man_Suits.ToString());
            full_description().Add("The_Creators", enums.Manufacturers.Stan_lee.ToString());
            full_description().Add("Cost",cost);
            full_description().Add("Wieght", weight);
            full_description().Add("Damage",damage );
            full_description().Add("Rounds", rounds);
            // return every fields in a Dictionary
            // key = field, value = field's value
            // example id = 1-1-1383 so we Add("id","1-1-1383")
            throw new NotImplementedException();
        }

        public override Dictionary<string, string> properties()
        {
            properties().Add("Cost", cost);
            properties().Add("Wieght", weight);
            properties().Add("Damage", damage);
            properties().Add("Rounds", rounds);
           
            
            // return all the custom properties in a dictionary
            // example property1 is Plasma_absortion_rate = 0.18
            // so we Add("Plasma absortion rate", "double")
            // same for the other
            throw new NotImplementedException();
        }

        public  string ToString(string format)
        {
            format = id + "," + manufacturer + "," + model + "," + type + "," + quantity + "," + damage + "," + weight + "," + cost + "," + rounds;
            return format;
            // return format id, type, manufacturer,..., property4
            throw new NotImplementedException();
        }
        
    }
}

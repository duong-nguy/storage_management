using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Iron_suits : abstractions.PRODUCT
    {
        string ID;       
        string MANUFACTURER= enums.Manufacturers.Stark_Industry.ToString();
        string TYPE= enums.Product_types.Iron_suites.ToString();
        string MODEL;
        string QUANTITY;
        string COLOUR;
        string AUTO_PILOT;
        string POWER_SHOOK_ABSORBENT;
        string MARTRIAL;
        

        // implement everythings that have throw new NotImplementedException();
        public Iron_suits(string id, string colour, string manufacturer, string type, string model, string auto_pilot, string power_shook_absorbent, string martrial, string quantity)
        {
            this.ID = id;
            this.MANUFACTURER = manufacturer;
            this.TYPE = type;
            this.MODEL = model;
            this.QUANTITY = quantity;
            this.COLOUR = colour;
            this.AUTO_PILOT = auto_pilot;
            this.POWER_SHOOK_ABSORBENT = power_shook_absorbent;
            this.MARTRIAL = martrial;
            
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
                return enums.Product_types.Iron_suites;
                throw new NotImplementedException();
            }
        }

        // when you are here goto enums.Manufacturers file
        public override Manufacturers manufacturer
        {
            get
            {
                return enums.Manufacturers.Stark_Industry;
                throw new NotImplementedException();
            }
        }

        public override string model {
            get
            {
                return MODEL;
                throw new NotImplementedException();
            }
        }

        public override string quantity {
            get
            {
                return QUANTITY;
                throw new NotImplementedException();
            }
        }

        // you can change the name and return type of these field
        public string colour {
            get
            {
                return COLOUR;
                throw new NotImplementedException();
            }
        }
        public string power_shook_absorbent
        {
            get
            {
                return power_shook_absorbent;
                throw new NotImplementedException();
            }
        }
        public string martrial {
            get
            {
                return MARTRIAL;
                throw new NotImplementedException();
            }
        }
        public string auto_pilot {
            get
            {
                return AUTO_PILOT;
                throw new NotImplementedException();
            }
        }

        public override Dictionary<string, string> full_description()
        {
            full_description().Add("Id", id);
            full_description().Add("model", model);
            full_description().Add("quantity", quantity);
            full_description().Add("Transformers", enums.Product_types.Iron_suites.ToString());
            full_description().Add("The_Creators", enums.Manufacturers.Stark_Industry.ToString());
            full_description().Add("Colour", colour);
            full_description().Add("Auto_pilot",auto_pilot);
            full_description().Add("Power_shook_absorbent", power_shook_absorbent);
            full_description().Add("Martrial", martrial);
            return full_description();
            throw new NotImplementedException();
        }

        public override Dictionary<string, string> properties()
        {
            properties().Add("Colour", colour);
            properties().Add("Auto_pilot", auto_pilot);
            properties().Add("Power_shook_absorbent", power_shook_absorbent);
            properties().Add("Martrial", martrial);
            return properties();
            throw new NotImplementedException();
        }

        public  string ToString(string format)
        {
            format = id + "," + manufacturer + "," + model + "," + type + "," + quantity + "," + colour + "," + auto_pilot + "," + power_shook_absorbent + "," + martrial;
            return format;
            // return format id, type, manufacturer,..., property4
            throw new NotImplementedException();
        }
        
    }
}

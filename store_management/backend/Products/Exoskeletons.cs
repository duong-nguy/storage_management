using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Exoskeletons : abstractions.PRODUCT
    {
     
        public Exoskeletons(
            string id, Product_types type,
            Manufacturers manufacturer,
            string model, int quantity,string colour,
            bool auto_pilot, int shook_absorbent, string material)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.colour = colour;
            this.auto_pilot = auto_pilot;
            this.shook_absorbent = shook_absorbent;
            this.material = material;
            
            
        }


        public override string id{get;}

         public override Product_types type{get;}


        public override Manufacturers manufacturer{get;}

        public override string model {
            get;
        }

        public override int quantity {
            get;
        }

        public string colour {
            get;
        }
        public int shook_absorbent
        {
            get;
        }
        public string material {
            get;
        }
        public bool auto_pilot {
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
            full_description.Add("Colour", colour);
            full_description.Add("Auto_pilot",auto_pilot.ToString());
            full_description.Add("Shock absorbent", shook_absorbent.ToString());
            full_description.Add("Material", material);
            return full_description;
        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Colour", "string");
            properties.Add("Auto_pilot", "bool");
            properties.Add("shock_absorbent", "int");
            properties.Add("Material", "string");
            return properties;
        }

        public override string ToString()
        {
            return id + "," + manufacturer + "," 
                + model + "," + type + "," + quantity + "," 
                + colour + "," + auto_pilot.ToString() + "," +shook_absorbent.ToString() +
                "," + material;
            

        }
        
    }
}

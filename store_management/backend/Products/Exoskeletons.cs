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
            int buffering, string material, bool auto_pilot)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.colour = colour;
            this.buffering = buffering;
            this.material = material;
            this.auto_pilot = auto_pilot;
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
        public int buffering
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
            full_description.Add("Buffering", buffering.ToString());
            full_description.Add("Material", material);
            full_description.Add("Auto pilot", auto_pilot.ToString());
            return full_description;
        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Colour", "string");
            properties.Add("Buffering", "int");
            properties.Add("Material", "string");
            properties.Add("Auto pilot", "bool");
            return properties;
        }

        public override string ToString()
        {
            return $"{id},{(int)type},{(int)manufacturer}, {model}," +
                $"{quantity},{colour},{buffering},{material},{auto_pilot}";
        }
        
    }
}

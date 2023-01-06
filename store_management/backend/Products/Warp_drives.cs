using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Warp_drives : abstractions.PRODUCT
    {
        public Warp_drives(
            string id, Product_types type, Manufacturers manufacturer,
            string model, int quantity, double spatial_compression_rate,
            bool artifictial_blackhole, bool artifictial_whitehole,
            int wrap_speed)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.spatial_compression_rate = spatial_compression_rate;
            this.artifictial_blackhole = artifictial_blackhole;
            this.artifictial_whitehole = artifictial_whitehole;
            this.wrap_speed = wrap_speed;
        }
        public override string id { get; }

        public override Product_types type { get; }

        public override Manufacturers manufacturer {
            get;
        }

        public override string model
        {
            get;
        }

        public override int quantity {
            get; 
        }
        public double spatial_compression_rate
        {
            get;
        }
        public bool artifictial_blackhole { get; }
        public bool artifictial_whitehole { get; }
        public int wrap_speed { get; }

        public override Dictionary<string, string> full_description()
        {
            Dictionary<string, string> full_description = new Dictionary<string, string>();
            full_description.Add("Id", id);
            full_description.Add("Type", type.ToString());
            full_description.Add("Manufacturer", manufacturer.ToString());
            full_description.Add("Model", model);
            full_description.Add("Quantity", quantity.ToString());
            full_description.Add("Spatial compression rate", spatial_compression_rate.ToString());
            full_description.Add("Artifictial blackhole", artifictial_blackhole.ToString());
            full_description.Add("Artifictial whitehole", artifictial_whitehole.ToString());
            full_description.Add("Wrap speed", wrap_speed.ToString());
            return full_description;
        }

        public override Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Spatial compression rate", "int");//double
            properties.Add("Artifictial blackhole", "bool");
            properties.Add("Artifictial whitehole", "bool");
            properties.Add("Wrap speed", "int");
            return properties;
        }
        public override string ToString()
        {
            return $"{id},{type},{manufacturer},{model},{quantity}" +
                $",{spatial_compression_rate},{artifictial_blackhole},{artifictial_whitehole}" +
                $"{wrap_speed}";
        }
    }
}

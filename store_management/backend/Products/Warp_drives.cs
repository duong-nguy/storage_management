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
            string model, int quantity, string power_by, int wrap_speed,
            bool artifictial_blackhole, bool artifictial_whitehole
            )
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.power_by = power_by;
            this.wrap_speed = wrap_speed;
            this.artifictial_blackhole = artifictial_blackhole;
            this.artifictial_whitehole = artifictial_whitehole;
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
        public string power_by
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
            full_description.Add("Type",
               Utility.make_pretty_string(type.ToString()));
            full_description.Add("Manufacturer",
                Utility.make_pretty_string(manufacturer.ToString()));
            full_description.Add("Model", model);
            full_description.Add("Quantity", quantity.ToString());
            full_description.Add("Power with", power_by.ToString());
            full_description.Add("Wrap speed", wrap_speed.ToString());
            full_description.Add("Artifictial blackhole", artifictial_blackhole.ToString());
            full_description.Add("Artifictial whitehole", artifictial_whitehole.ToString());
            return full_description;
        }

        public static Dictionary<string, string> properties()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("Power with", "string");
            properties.Add("Wrap speed", "int");
            properties.Add("Artifictial blackhole", "bool");
            properties.Add("Artifictial whitehole", "bool");
            return properties;
        }
        public override string ToString()
        {
            return $"{id},{(int)type},{(int)manufacturer},{model},{quantity}" +
                $",{power_by},{wrap_speed},{artifictial_blackhole}," +
                $"{artifictial_whitehole}";
        }
        public override string get_string_data()
        {
            return $"{id},{type},{manufacturer},{model},quantity={quantity}" +
                $",power_by={power_by},wrap_speed={wrap_speed}" +
                $",artifictial_blackhole={artifictial_blackhole}," +
                $"artifictial_whitehole={artifictial_whitehole}";
        }
    }
}

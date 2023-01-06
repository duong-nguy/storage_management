using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Spider_Man_Suits : abstractions.PRODUCT
    {
        string ID;
        string MANUFACTURER = enums.Manufacturers.Stan_lee.ToString();
        string TYPE = enums.Product_types.Spider_Man_Suits.ToString();
        string MODEL;
        string QUANTITY;
        string COLOUR;
        string OWENER;
        string TRACKER;
        string BUILT_IN_HEATER;
        // implement everythings that have throw new NotImplementedException();
        public Spider_Man_Suits(string id, string colour, string manufacturer, string type, string model, string quantity , string owner, string tracker, string built_in_heater)
        {
            this.ID = id;
            this.MANUFACTURER = manufacturer;
            this.TYPE = type;
            this.MODEL = model;
            this.QUANTITY = quantity;
            this.COLOUR = colour;
            this.OWENER = owner;
            this.TRACKER = tracker;
            this.BUILT_IN_HEATER = built_in_heater;
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
                return enums.Product_types.Spider_Man_Suits;
                throw new NotImplementedException();
            }
        }

        // when you are here goto enums.Manufacturers file
        public override Manufacturers manufacturer
        {

            get
            {
                return enums.Manufacturers.Stan_lee;
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

        public override string quantity
        {

            get
            {
                return QUANTITY;
                throw new NotImplementedException();
            }
        }

        // you can change the name and return type of these field
        public string colour
        {

            get
            {
                return COLOUR;
                throw new NotImplementedException();
            }
        }
        public string owener
        {

            get
            {
                return OWENER;
                throw new NotImplementedException();
            }
        }
        public string tracker
        {

            get
            {
                return TRACKER;
                throw new NotImplementedException();
            }
        }
        public string built_in_heater
        {

            get
            {
                return BUILT_IN_HEATER;
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
            full_description().Add("Colour", colour);
            full_description().Add("Owner", owener);
            full_description().Add("Tracker", tracker);
            full_description().Add("Build_in_heater", built_in_heater);
            return full_description();
            // return every fields in a Dictionary
            // key = field, value = field's value
            // example id = 1-1-1383 so we Add("id","1-1-1383")
            throw new NotImplementedException();
        }

        public override Dictionary<string, string> properties()
        {

            properties().Add("Colour", colour);
            properties().Add("Owner", owener);
            properties().Add("Tracker", tracker);
            properties().Add("Build_in_heater", built_in_heater);
            return properties();
            throw new NotImplementedException();
        }

        public  string ToString(string format)
        {
            format = id + "," + manufacturer + "," + model + "," + type + "," + quantity + "," + colour + "," + owener + "," + tracker + "," + built_in_heater;
            return format;
            // return format id, type, manufacturer,..., property4
            throw new NotImplementedException();
        }
        
    }
}

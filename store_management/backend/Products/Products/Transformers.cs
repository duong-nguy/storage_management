using store_management.enums;
using System;
using System.Collections.Generic;

namespace store_management.backend.Products
{
    class Transformers : abstractions.PRODUCT
    {
        string ID;
        string TEAM;
        string MANUFACTURER=enums.Manufacturers.The_Creators.ToString();
        string TYPE=enums.Product_types.Transformers.ToString();
        string MODEL;
        string SPACE;
        string SPEED;
        string STRENGTH;
        string QUANTITY;
        // implement everythings that have throw new NotImplementedException();
        public Transformers(string id, string team, string manufacturer, string type,string model,string space,string speed,string strength,string quantity)
        {
            this.ID=id;
            this.TEAM=team;
            this.MANUFACTURER=manufacturer;
            this.TYPE=type;
            this.MODEL=model;
            this.SPACE=space;
            this.SPEED=speed;
            this.STRENGTH=strength;
            this.QUANTITY = quantity;
 
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
                return enums.Product_types.Transformers;
                throw new NotImplementedException();
            }
        }

        // when you are here goto enums.Manufacturers file  

        public override Manufacturers manufacturer
        {
            get
            {
                return enums.Manufacturers.The_Creators;
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

        public override string quantity {
            get
            {
                return QUANTITY;
                throw new NotImplementedException();
            }
        }

        // you can change the name and return type of these field
        public  string team {
            get
            {
                return TEAM;
                throw new NotImplementedException();
            }
        }
        public string space {
            get
            {
                return SPACE;
                throw new NotImplementedException();
            }
        }
        public string strength {
            get
            {
                return STRENGTH;
                throw new NotImplementedException();
            }
        }
        public string speed {
            get
            {
                return SPEED;
                throw new NotImplementedException();
            }
        }


        public override Dictionary<string, string> full_description()
        {
            full_description().Add("Id", id);
            full_description().Add("model",model);
            full_description().Add("quantity",quantity);
            full_description().Add("Team", team);
            full_description().Add("Transformers", enums.Product_types.Transformers.ToString());
            full_description().Add("The_Creators", enums.Manufacturers.The_Creators.ToString());
            full_description().Add("space", space);
            full_description().Add("strength", strength.ToString());
            full_description().Add("speed", speed.ToString());
            return full_description();

        }

        public override Dictionary<string, string> properties()
        {
            properties().Add("Team", team);
            properties().Add("space", space);
            properties().Add("strength", strength.ToString());
            properties().Add("speed", speed.ToString());

            return properties();

        }

        public string ToString(string format)
        {

                format = ID + "," + MANUFACTURER + "," + MODEL + "," + TYPE + "," + quantity + "," + TEAM + "," + SPACE + "," + STRENGTH + "," + SPEED;
                return format;
            
            // return format id, type, manufacturer,..., property4
            throw new NotImplementedException();
        }

    }
}

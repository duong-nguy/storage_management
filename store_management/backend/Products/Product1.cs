using store_management.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.Products
{
    class Product1 : abstractions.PRODUCT
    {
        // implement everythings that have throw new NotImplementedException();
        public Product1()
        {
            throw new NotImplementedException();
        }


        public override string id => throw new NotImplementedException();
        // implementation example it just need to return the id
        // public override string id { get; }
        // same as the other

        // when you are here goto enums.Product_types file
        public override Product_types type => throw new NotImplementedException();

        // when you are here goto enums.Manufacturers file
        public override Manufacturers manufacturer => throw new NotImplementedException();

        public override string model => throw new NotImplementedException();

        public override string quantity => throw new NotImplementedException();

        // you can change the name and return type of these field
        public string property1 => throw new NotImplementedException();
        public string property2 => throw new NotImplementedException();
        public string property3 => throw new NotImplementedException();
        public string property4 => throw new NotImplementedException();

        public override Dictionary<string, string> full_description()
        {
            // return every fields in a Dictionary
            // key = field, value = field's value
            // example id = 1-1-1383 so we Add("id","1-1-1383")
            throw new NotImplementedException();
        }

        public override Dictionary<string, string> properties()
        {
            // return all the custom properties in a dictionary
            // example property1 is Plasma_absortion_rate = 0.18
            // so we Add("Plasma absortion rate", "double")
            // same for the other
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // return format id, type, manufacturer,..., property4
            throw new NotImplementedException();
        }
        
    }
}

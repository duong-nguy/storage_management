using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.abstractions
{
    abstract class PRODUCT
    {
        public abstract string id { get; }
        public abstract enums.Product_types type { get; }
        public abstract enums.Manufacturers manufacturer { get; }
        public abstract string model { get; }
        public abstract string quantity { get; }
        public abstract Dictionary<string, string> full_description();
        public abstract Dictionary<string, string> properties();
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend.abstractions
{
    abstract class PRODUCT
    {
        public abstract string id { get; }
        public abstract string type { get; }
        public abstract string manufacturer { get; }
        public abstract string model { get; }
        public abstract string quantity { get; }
        public abstract Dictionary<string, string> full_description();
        //return all properties of proudct in a dictionary
        // overwrite ToString method return: id,type,manufacturer,model,quantity
    }
}

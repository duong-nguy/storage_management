using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_management.backend
{
    static class Product_factory
    {
        public static abstractions.PRODUCT create_product(
            string id,
            enums.Product_types type,
            enums.Manufacturers manufacturer,
            string model,
            int quantity,
            params string[] args)
        {

            switch (type)
            {
                case enums.Product_types.Androids:
                    return new Products.Androids(
                        id, type, manufacturer, model,quantity,
                        args[0],Convert.ToInt16(args[1]),
                        Convert.ToInt16(args[2]),
                        Convert.ToInt16(args[3]));
                case enums.Product_types.Drones:
                    return new Products.Drones(id, type, manufacturer, model, quantity,
                        Convert.ToInt16(args[0]), args[1], Convert.ToInt16(args[2]),
                        Convert.ToBoolean(args[3]));
                    
                case enums.Product_types.Exoskeletons:
                    return new Products.Exoskeletons(id, type, manufacturer, model, quantity,
                        args[0], Convert.ToInt16(args[1]), args[2],
                        Convert.ToBoolean(args[3]));

                case enums.Product_types.Space_Guns:
                    return new Products.Space_Guns(id, type, manufacturer, model, quantity,
                        Convert.ToInt16(args[0]), Convert.ToInt16(args[1]),
                        Convert.ToInt16(args[2]), Convert.ToInt16(args[3]));
                case enums.Product_types.Warp_drives:
                    return new Products.Warp_drives(id, type, manufacturer, model, quantity,
                        args[0], Convert.ToBoolean(args[1]),
                        Convert.ToBoolean(args[2]), Convert.ToInt16(args[3]));

                default:
                    throw new Exception("Can not find product type");
            }
        }
        public static abstractions.PRODUCT create_product(
            string[] product)
        {
            enums.Product_types type = (enums.Product_types)
               Convert.ToInt16(product[1]);
            enums.Manufacturers manufacturer = (enums.Manufacturers)
               Convert.ToInt16(product[2]);

            switch (type)
            {
                case enums.Product_types.Androids:
                    return new Products.Androids(
                        product[0], type, manufacturer,
                        product[3], Convert.ToInt16(product[4]),
                        product[5], Convert.ToInt16(product[6]),
                        Convert.ToInt16(product[7]),
                        Convert.ToInt16(product[8]));
                case enums.Product_types.Drones:
                    return new Products.Drones(product[0], type, manufacturer,
                        product[3], Convert.ToInt16(product[4]),
                        Convert.ToInt16(product[5]), product[6], Convert.ToInt16(product[7]),
                        Convert.ToBoolean(product[8]));

                case enums.Product_types.Exoskeletons:
                    return new Products.Exoskeletons(product[0], type, manufacturer,
                        product[3], Convert.ToInt16(product[4]),
                        product[5], Convert.ToInt16(product[6]), product[7],
                        Convert.ToBoolean(product[8]));

                case enums.Product_types.Space_Guns:
                    return new Products.Space_Guns(product[0], type, manufacturer,
                        product[3], Convert.ToInt16(product[4]),
                        Convert.ToInt16(product[5]), Convert.ToInt16(product[6]),
                        Convert.ToInt16(product[7]), Convert.ToInt16(product[8]));
                case enums.Product_types.Warp_drives:
                    return new Products.Warp_drives(product[0], type, manufacturer,
                        product[3], Convert.ToInt16(product[4]),
                        product[5], Convert.ToBoolean(product[6]),
                        Convert.ToBoolean(product[7]), Convert.ToInt16(product[8]));

                default:
                    throw new Exception("Can not find product type");
            }

        }
        public static Dictionary<string,string> get_product_properties(enums.Product_types type)
        {
            switch (type)
            {
                case enums.Product_types.Androids:
                    return Products.Androids.properties();
                case enums.Product_types.Drones:
                    return Products.Drones.properties();
                case enums.Product_types.Exoskeletons:
                    return Products.Exoskeletons.properties();
                case enums.Product_types.Space_Guns:
                    return Products.Space_Guns.properties();
                case enums.Product_types.Warp_drives:
                    return Products.Warp_drives.properties();
                default:
                    throw new Exception("Can not find product type");
            }
        }
    }
}

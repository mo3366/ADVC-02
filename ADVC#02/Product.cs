using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ADVC_02
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }

       public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }


        public static void PrintReport(List<Product> products, Action<Product> printAction)
        {
            foreach (var pro in products)
            {
                printAction(pro);
            }
            return;
        }

        public static List<string> TransformProducts( List<Product> products, Func<Product, string> transformFunction)
        {
            List<string> result = new List<string>();

            foreach (var product in products)
            {
                result.Add(transformFunction(product));
            }

            return result;
        }
    }
}

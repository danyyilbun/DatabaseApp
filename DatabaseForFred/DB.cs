using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseForFred
{
    public class DB
    {
        private static Demo1Entities myDb = new Demo1Entities();

        public static IEnumerable<Product> GetProduct()
        {
            return myDb.Products.ToList();
        }
        public static Product GetProduct(int id)
        {
            return myDb.Products.Find(id);
        }

    }
}

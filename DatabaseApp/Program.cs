using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseForFred;
namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProduct = DB.GetProduct(1);
        }
    }
}

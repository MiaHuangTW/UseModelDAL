using MVCwithADO.NET.Models.DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseModelDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDal p = new ProductDal();
            IEnumerable<DataRow> table = p.Get();
            
            foreach (System.Data.DataRow row in table)
            {
                Console.WriteLine("{0} : {1}",row["ProductID"],row["ProductName"]);
            }

            Console.Read();
        }
    }
}

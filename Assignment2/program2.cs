using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
          //problem number 2===============================================================================

        //public class Product
        //{
          

        //    // Property for ProductId
        //    public int ProductId { get; set; }

        //    // Property for ProductName
        //    public string ProductName { get; set; }

        //    // Property for Price
        //    public decimal Price { get; set; }


        //    // Property for UnitOfMeasurement
        //    public string UnitOfMeasurement { get; set; }

        //    // Property for Qty
        //    public int Qty { get; set; }
            
        
        
        //}

    //problem number 5=============================================================================================

    public class Product
    {
        // Static variable to keep track of the last assigned ProductId
        private static int lastProductId = 0;

        // Property for ProductId
        public int ProductId { get; }

        // Property for ProductName
        public string ProductName { get; set; }

        // Property for Price
        public decimal Price { get; set; }


        // Property for UnitOfMeasurement
        public string UnitOfMeasurement { get; set; }

        // Property for Qty
        public int Qty { get; set; }



    }


}

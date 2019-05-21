using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDImplementation
{
    class Cart : ICart
    {
        // Product productObj = new Product();
        IProduct productObject = new Product();
         void ICart.CartImplementation()
        {
            var choice = 9;
           
            do
            {
                Console.WriteLine("Select 1 for purchasing product ");
                Console.WriteLine("Select 0 to exit");
                try
                { choice = int.Parse(Console.ReadLine()); }
                catch(Exception e)
                {
                    Console.WriteLine("Enter valid input");
                    Console.WriteLine();
                }
                
                switch (choice)
                {
                    case 0 :
                        break;
                        
                    case 1 :
                        productObject.ProductImplementation();
                        break;
                 
                    default :
                        Console.WriteLine("Enter valid choice");
                        Console.WriteLine();
                        break;
                }

            } while (choice != 0);

         //   productObj.CalculatePrice();
        }
         void ICart.IsReadyToCheckOut()
        {
          
            //bool response = false;
            //if (response = = true)
            //{
                
            //}

            //    return response;
        }
    }
}

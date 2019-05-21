using System;

namespace SOLIDImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ECommerce Portal");
           
            ICart cartObject = new Cart();
            cartObject.CartImplementation();


            
                          
        }    
    }
}

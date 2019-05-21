using System;


namespace SOLIDImplementation
{
    class Mobile : ElectronicProduct, IMobile, IQuantityRequired
    {
        public void MobileImplementation()
        {
            QuantityRequired();
        }

        public void QuantityRequired()
        {
            int availableQuantityMobile = 100;
            int quantityMobile=0;
            Console.WriteLine("Enter number of mobiles you are planning to buy : ");
            availableQuantityMobile -= quantityMobile;
            Console.WriteLine($"Available quantity - {availableQuantityMobile}");
            Console.WriteLine("Cost of one mobile - $100");
            try
            {
                quantityMobile = int.Parse(Console.ReadLine());
                Console.WriteLine(" {0} items added to cart", quantityMobile);
                Console.WriteLine();
               
                int choice = 9;
                do
                {
                    Console.WriteLine("Do you still want to buy mobile?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");

                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            QuantityRequired();
                            break;



                        default:
                            Console.WriteLine("Enter valid choice.");
                            break;
                    }
                } while (choice == 2);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
          
        }
    }
}

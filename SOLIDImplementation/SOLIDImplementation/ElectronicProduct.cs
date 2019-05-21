using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDImplementation
{
    class ElectronicProduct : Product, IElectronicProduct
    {
        public void ChooseRAM()
        {
            throw new NotImplementedException();
        }

        public void ElectronicProductImplementation()
        {
            IMobile mobileObject = new Mobile();
            ILaptop laptopObject = new Laptop();
            IElectronicProduct electronicObject = new ElectronicProduct();
            ICart cartObject = new Cart();

            var choice = 9;

            do
            {
                Console.WriteLine("Select 1 for Mobile ");
                Console.WriteLine("Select 2 for Laptop ");
                Console.WriteLine();
                Console.WriteLine("Select 3 for main menu");
                Console.WriteLine();
                Console.WriteLine("Select 0 for previous menu");
                try
                { choice = int.Parse(Console.ReadLine()); }
                catch (Exception)
                {
                    Console.WriteLine("Enter valid input");
                    Console.WriteLine();
                }

                switch (choice)
                {
                    case 0:
                        break;

                    case 1:
                        mobileObject.MobileImplementation();
                        break;

                    case 2:
                        laptopObject.LaptopImplementation();
                        break;

                    case 3:
                        cartObject.CartImplementation();
                        break;

                  

                    default:
                        Console.WriteLine("Enter valid choice");
                        Console.WriteLine();
                        break;
                }

            } while (choice != 0);
        }
    }
}

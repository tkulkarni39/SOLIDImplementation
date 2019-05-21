using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDImplementation
{
    class Product : IProduct
    {
       

        public void ProductImplementation()
        {
            IElectronicProduct electronicObject = new ElectronicProduct();
            IClothingProduct clothingObject = new ClothingProduct();
            ICart cartObject = new Cart();

            var choice = 9;

            do
            {
                Console.WriteLine("Select 1 for electronic products ");
                Console.WriteLine("Select 2 for clothing products ");
                // Console.WriteLine("Select 3 for previous menu ");
                Console.WriteLine();
                Console.WriteLine("Select 3 for main menu");
                Console.WriteLine();
                Console.WriteLine("Select 0 to previous menu");
                try
                { choice = int.Parse(Console.ReadLine()); }
                catch (Exception e)
                {
                    Console.WriteLine("Enter valid input");
                    Console.WriteLine();
                }

                switch (choice)
                {
                    case 0 :
                        break;

                    case 1 :
                        electronicObject.ElectronicProductImplementation();
                        break;

                    case 2 :
                        clothingObject.ClothingProductImplementation();
                        break;

                    //case 3 :
                    //    cartObject.CartImplementation();
                    //    break;

                    case 3 :
                        cartObject.CartImplementation();
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        Console.WriteLine();
                        break;
                }

            } while (choice != 0);

        }


        void IProduct.CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}

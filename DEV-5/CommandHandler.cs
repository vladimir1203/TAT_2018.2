﻿using System;

namespace DEV5
{
    /// <summary>
    /// Command handler implements command processing
    /// and invoking required methods.
    /// </summary>
    class CommandHandler
    {
        /// <summary>
        /// Invokes the required method entered from the keyboard.
        /// </summary>
        /// <param name="storageOfProduct">Object of ProductStorage class.</param>
        public CommandHandler(ProductStorage<Product> storageOfProduct)
        {
            try
            {             
                bool flag = true;
                Console.WriteLine("\nEnter the command for cars (count brands, count all, average price, average price 'brand', exit)");
                while (flag)
                {
                    Console.Write(">");
                    string caseSwitch = Console.ReadLine();
                    string brand = BrandFinder(ref caseSwitch);                   
                    switch (caseSwitch)
                    {
                        case "count brands":
                            BrandsCounter typesCounter = new BrandsCounter();
                            typesCounter.Execute(storageOfProduct);
                            break;
                        case "count all":
                            AllCounter allCounter = new AllCounter();
                            allCounter.Execute(storageOfProduct); ;
                            break;
                        case "average price":
                            AveragePriceCounter averagePriceCounter = new AveragePriceCounter();
                            averagePriceCounter.Execute(storageOfProduct); ;
                            break;
                        case "average price ":
                            AveragePriceCounter averagePriceCounterType = new AveragePriceCounter();
                            averagePriceCounterType.Execute(storageOfProduct, brand.Trim());
                            break;
                        case "exit":
                            flag = false;
                            break;
                        default:
                            Console.Write("Unknown command. Try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        /// <summary>
        ///Finds the presence of a car brand in the string and cuts it out of it into a separate string, which returns.
        /// </summary>
        /// <param name="caseSwitch">Entered the command for switch choosing.</param>
        /// <returns>Brand for AveragePriceCouner method.</returns>
        public static string BrandFinder(ref string caseSwitch)
        {
            string brand = string.Empty;
            if (caseSwitch.Length > "average price ".Length)
            {
                brand = caseSwitch.Substring("average price ".Length);
                caseSwitch = caseSwitch.Remove("average price ".Length, caseSwitch.Length - "average price ".Length);
            }
            return brand;
        }
    }
}
        
        
        

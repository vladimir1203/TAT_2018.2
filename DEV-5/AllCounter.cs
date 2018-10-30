﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV5
{
    /// <summary>
    /// All counter implementing method for calculate all types of cars.
    /// </summary>
    class AllCounter : Icountable
    {
        /// <summary>
        /// Method for count all types of cars.
        /// </summary>
        /// <param name="cars">Lis of cars.</param>
        /// <param name="arg">Parametr arg.</param>
        public void Count(List<Car> cars, string arg = null)
        {
            if (cars.Any())
            {
                int count = 0;
                foreach (var product in cars)
                {
                    count += product.quantity;
                }
                Console.Write("Total number of cars: " + count + "\n");
            }
            else
            {
                throw new ArgumentNullException();
            }    
        }        
    }
}
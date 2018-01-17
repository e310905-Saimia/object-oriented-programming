using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    /// <summary>
    /// Common methods which do some problemsolving 
    /// Generate data
    /// </summary>
    class Utils
    {
        private static Random rnd = new Random();

        /// <summary>
        /// Generate new random phonenumber
        /// </summary>
        /// <returns>string phonenumber</returns>
        public static string GenerateNewRandomPhone()
        {
            string phone = "040";

            for (int i = 0; i < 7; i++)
            {
                phone += rnd.Next(0, 10);
            }
            
            return phone;
        }
    }
}

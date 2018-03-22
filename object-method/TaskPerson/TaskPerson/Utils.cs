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
        private static string _separator= new string('-', 100);

        public static string Separator { get => _separator;
            // set => _separator = new string(char.Parse(value),100);
        }

        public static void SetSeparator(char chr, int count)
        {
            _separator = new string(chr, count);
        }
        /// <summary>
        /// Generate new random phonenumber
        /// </summary>
        /// <returns>string phonenumber</returns>
        public static string GenerateNewRandomPhone()
        {
            string phone = "040";
            if (rnd.NextDouble() >= 0.5)
                phone = "050";
            

            for (int i = 0; i < 7; i++)
            {
                phone += rnd.Next(0, 10);
            }
            
            return phone;
        }

        public static string GetPhotoType()
        {
            if (rnd.NextDouble() > 0.5)
                return "WORK";
            else            
                return "HOME";            
        }

        private enum PhoneType
        {
            WORK,
            HOME            
        };
    }
}

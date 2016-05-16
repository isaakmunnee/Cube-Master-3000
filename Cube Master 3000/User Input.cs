using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Master_3000
{
    public static class User_Input
    {
        /// <summary>
        /// Creates a cube from User Specified variables
        /// </summary>
        /// <returns>A cube class</returns>
        public static Cube GetUserSpecifiedCube()
        {
            Console.WriteLine("New Cube!!");
            float xui = GetUserSpecifiedValue("Enter X Value");
            float yui = GetUserSpecifiedValue("Enter Y Value");
            float zui = GetUserSpecifiedValue("Enter Z Value");
            return new Cube(xui, yui, zui);
        }

        /// <summary>
        /// Gets a number (float) from the user with a printline first.
        /// </summary>
        /// <param name="preface">What to tell the user to input.</param>
        /// <returns>A user specified float value</returns>
        public static float GetUserSpecifiedValue(string preface)
        {
            float? number = null;
            
            while(number == null)
            {
                float numberr;
                Console.WriteLine(preface);
                if (float.TryParse(Console.ReadLine(), out numberr))
                {
                    number = numberr;
                    break;
                }
                else
                {
                    Console.WriteLine("That's not a number...");
                }
            }
            return number.Value;
        }

        /// <summary>
        /// Ask's user if he/she want's to perform another calculation
        /// </summary>
        /// <returns>True if yes</returns>
        public static bool StartAgain()
        {
            Console.WriteLine("Perform Another Calculation? (Y for yes, anything else to close");
            char readkey = Console.ReadKey().KeyChar;
            Console.WriteLine();    //make some whitespace so it don't fuckup the next printout
            if (readkey == 'y' || readkey == 'Y')
                return true;
            return false;
        }
    }
}

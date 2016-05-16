using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Master_3000
{
    public static class User_Input
    {
        public static Cube GetUserSpecifiedCube()
        {
            Console.WriteLine("New Cube!!");
            float xui = GetUserSpecifiedValue("Enter X Value");
            float yui = GetUserSpecifiedValue("Enter Y Value");
            float zui = GetUserSpecifiedValue("Enter Z Value");
            return new Cube(xui, yui, zui);
        }

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
    }
}

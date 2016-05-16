using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Master_3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube userCube;
            
            START:
            userCube = User_Input.GetUserSpecifiedCube();
            Console.WriteLine(String.Format("Cube Volume: {0}u^3, Cube Surface Area: {1}u^2.", userCube.volume, userCube.surfaceArea));

            if (User_Input.StartAgain())
                goto START;
        }
    }
}
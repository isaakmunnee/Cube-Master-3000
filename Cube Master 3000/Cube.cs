using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Master_3000
{
    public class Cube
    {
        /// <summary>
        /// Don't use this twat.
        /// </summary>
        public Cube() { }

        /// <summary>
        /// Makes a new cube with the given calues (x,y,z)
        /// </summary>
        /// <param name="p1">X value</param>
        /// <param name="p2">Y value</param>
        /// <param name="p3">Z value</param>
        public Cube(float p1, float p2, float p3)
        {
            x = p1;
            y = p2;
            z = p3;

            xFace = new Side(y, z);
            yFace = new Side(x, z);
            zFace = new Side(x, y);

        }

        public float x;
        public float y;
        public float z;

        /// <summary>
        /// The size of the cube in volume units (units^3)
        /// </summary>
        public float size
        {
            get
            {
                return x * y * z;
            }
        }

        /// <summary>
        /// Side X*Y (perpendicular to the z axis)
        /// </summary>
        public Side zFace;
        /// <summary>
        /// Side Y*Z (perpendicular to the x axis)
        /// </summary>
        public Side xFace;
        /// <summary>
        /// Side X*Z (perpendicular to the y axis);
        /// </summary>
        public Side yFace;

        public class Side
        {
            public Side() { }

            /// <summary>
            /// Makes a new side (x,y)
            /// </summary>
            /// <param name="p1">X value</param>
            /// <param name="p2">Y value</param>
            public Side(float p1, float p2)
            {
                x = p1;
                y = p2;
            }

            public float x;
            public float y;

            public float size
            {
                get
                {
                    return x * y;
                }
            }
        }
    }
}

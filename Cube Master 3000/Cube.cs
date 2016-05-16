﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Master_3000
{
    public class Cube
    {

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

        public class Side
        {
            public Side() { }

            public float x;
            public float y;
        }
    }
}
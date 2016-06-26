using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Constant
    {
        public static ColorChannel black = new ColorChannel(0, 0, 0);
        public static ColorChannel white = new ColorChannel(1, 1, 1);
        public static ColorChannel red = new ColorChannel(1, 0, 0);
        public static ColorChannel green = new ColorChannel(0, 1, 0);
        public static ColorChannel blue = new ColorChannel(0, 0, 1);

        public static Vector3 light = new Vector3(1, 1, 1).nor();

        public static ColorChannel lightChannel = white;
    }
}

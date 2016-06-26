using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class ColorChannel
    {
        public float r { get; set; }
        public float b { get; set; }
        public float g { get; set; }

        public ColorChannel(float r, float g, float b)
        {
            this.r = r;
            this.b = b;
            this.g = g;
        }

        public ColorChannel add(ColorChannel colorchannel)
        {
            return new ColorChannel(r + colorchannel.r, g + colorchannel.g, b + colorchannel.b);
        }

        public ColorChannel mul(float n)
        {
            return new ColorChannel(r * n, g * n, b * n);
        }

        public ColorChannel mud(ColorChannel colorchannel)
        {
            return new ColorChannel(r * colorchannel.r, g * colorchannel.g, b * colorchannel.b);
        }
    }
}

using Ray.material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    abstract class Base
    {
        public Material material;
        abstract public InsertsectResult insertsect(Ray3 ray);
    }
}

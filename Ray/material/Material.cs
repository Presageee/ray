using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.material
{
    abstract class Material
    {
        public float reflectiveness;
        abstract public ColorChannel calcColor(Ray3 ray, Vector3 position, Vector3 normal);
    }
}

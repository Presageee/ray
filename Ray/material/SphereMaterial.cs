using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.material
{
    class SphereMaterial : Material
    {
        public ColorChannel diffuse;
        public ColorChannel specular;
        public float shininess;
        public SphereMaterial(ColorChannel diff, ColorChannel spec, float shin, float refect)
        {
            this.diffuse = diff;
            this.specular = spec;
            this.shininess = shin;
            this.reflectiveness = refect;
        }

        public override ColorChannel calcColor(Ray3 ray, Vector3 position, Vector3 normal)
        {
            float nl = normal.dot(Constant.light);
            Vector3 h = (Constant.light.sub(ray.getDirection)).nor();
            float nh = normal.dot(h);
            ColorChannel tmpDiff = diffuse.mul(Math.Max(nl, 0));
            ColorChannel tmpSpec = specular.mul(Math.Max(nh, 0));
            return Constant.lightChannel.mud(tmpDiff.add(tmpSpec));
        }
    }
}

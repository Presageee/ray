using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Reflect
    {
        public static ColorChannel calcReflectChannel(Union b, Ray3 ray, int reflectTime)
        {
            InsertsectResult result = b.insertsect(ray);
            if (result.sphere != null)
            {
                float reflectiveness = result.sphere.material.reflectiveness;
                ColorChannel color = result.sphere.material.calcColor(ray, result.position, result.normal);
                color = color.mul(1 - reflectiveness);
                if (reflectiveness > 0 && reflectTime > 0)
                {
                    Vector3 tmpDir = result.normal.mul(-2 * result.normal.dot(ray.getDirection)).add(ray.getDirection);
                    Ray3 newRay = new Ray3(result.position, tmpDir);
                    ColorChannel tmp = calcReflectChannel(b, newRay, reflectTime - 1);
                    color = color.add(tmp.mul(reflectiveness));
                }
                return color;
            }
            else
            {
                return Constant.black;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Panel : Base
    {
        public Vector3 n;
        public float d;
        public Vector3 positon;

        public Panel(Vector3 v, float d)
        {
            this.n = v;
            this.d = d;
            this.positon = n.mul(d);
        }

        public override InsertsectResult insertsect(Ray3 ray)
        {
            float a = ray.getDirection.dot(this.n);
            if (a >= 0)
            {
                return new InsertsectResult();
            }
            float b = n.dot(ray.getOrigin.sub(positon));
            float distance = -b / a;
            Vector3 nPosition = ray.getPoint(distance);
            return new InsertsectResult(this, distance, nPosition, n);
        }
    }
}

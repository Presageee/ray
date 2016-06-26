using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Sphere : Base
    {
        private int radius;

        private int sqrtRadius;

        private Vector3 center;

        public Sphere(Vector3 v, int radius)
        {
            this.center = v;
            this.radius = radius;
            sqrtRadius = radius * radius;
        }

        public int getSqrtRaduis
        {
            get
            {
                return this.sqrtRadius;
            }
        }


        public override InsertsectResult insertsect(Ray3 ray)
        {
            Vector3 v = ray.getOrigin.sub(this.center);
            float c = (v.unSqrtLength() - this.sqrtRadius);
            float dv = ray.getDirection.dot(v);
            if (dv <= 0)
            {
                float dis = dv * dv - c;
                if (c >= 0)
                {
                    float distance = -dv - (float)Math.Sqrt(dis);
                    Vector3 position = ray.getPoint(distance);
                    Vector3 normal = position.sub(this.center).nor();
                    InsertsectResult insertsect = new InsertsectResult(this, distance, position, normal);
                    return insertsect;
                } 
            }
            return new InsertsectResult();
        }
    }
}

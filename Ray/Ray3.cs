using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Ray3
    {
        private Vector3 origin;
        private Vector3 direction;

        public Ray3(Vector3 o, Vector3 d)
        {
            this.origin = o;
            this.direction = d;
        }
        public Vector3 getOrigin
        {
            get
            {
                return this.origin;
            }
        }

        public Vector3 setOrigin
        {
            set
            {
                this.origin = value;
            }
        }

        public Vector3 getDirection
        {
            get
            {
                return this.direction;
            }
        }

        public Vector3 setDirection
        {
            set
            {
                this.direction = value;
            }
        }

        
        public Vector3 getPoint(float p)
        {
            return this.origin.add(this.direction.mul(p));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class PrespectCamera
    {
        public Vector3 eye;

        public Vector3 up;

        public Vector3 right;

        public Vector3 realUp;

        public Vector3 realRight;

        public int fov;

        public float fovscale;
        
        public PrespectCamera(Vector3 eye, Vector3 up, Vector3 right, int fov)
        {
            this.eye = eye;
            this.up = up;
            this.right = right;
            this.fov = fov;
        }

        public void init()
        {
            this.realRight = up.cross(right);
            this.realUp = realRight.cross(up);
            
            this.fovscale = (float)Math.Tan(fov * Math.PI * 0.5 / 180) * 2;
        }

        public Ray3 GenerRay(float x, float y)
        {
            Vector3 r = realRight.mul(((float)(x - 0.5) * fovscale));
            Vector3 u = realUp.mul(((float)(y - 0.5) * fovscale));
            return new Ray3(this.eye, this.up.add(r).add(u).nor());
        }
    }
}

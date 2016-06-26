using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Vector3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 copy()
        {
            return new Vector3(this.x, this.y, this.z);
        }

        public float length()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public float unSqrtLength()
        {
            return this.x * this.x + this.y * this.y + this.z * this.z;
        } 

        public Vector3 nor()
        {
            float scale = 1 / length();
            return new Vector3((scale * this.x), (scale * this.y), (scale * this.z));
        }

        public Vector3 negate()
        {
            return new Vector3(-1 * this.x, -1 * this.y, -1 * this.z);
        }

        public Vector3 add(Vector3 v)
        {
            return new Vector3(this.x + v.x, this.y + v.y, this.z + v.z);
        }

        public Vector3 sub(Vector3 v)
        {
            return new Vector3(this.x - v.x, this.y - v.y, this.z - v.z);
        }

        public Vector3 mul(float n)
        {
            return new Vector3((this.x * n), (this.y * n), (this.z * n));
        }

        public Vector3 div(int n)
        {
            float scale = 1 / n;
            return new Vector3((this.x * scale), (this.y * scale), (this.z * scale));
        }

        public float dot(Vector3 v)
        {
            return this.x * v.x + this.y * v.y + this.z * v.z;
        }

        public Vector3 cross(Vector3 v)
        {
            return new Vector3(-this.z * v.y + this.y * v.z, this.z * v.x - this.x * v.z, -this.y * v.x + this.x * v.y);
        } 
    }
}

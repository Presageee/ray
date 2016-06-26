using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class InsertsectResult
    {
        public Base sphere;

        public float distance;

        public Vector3 position;

        public Vector3 normal;
        
        public InsertsectResult()
        {
            this.sphere = null;
            this.distance = 0;
            this.position = new Vector3(0, 0, 0);
            this.normal = new Vector3(0, 0, 0);
        }
        public InsertsectResult(Base sphere, float distance, Vector3 position, Vector3 normal)
        {
            this.sphere = sphere;
            this.distance = distance;
            this.position = position;
            this.normal = normal;
        } 
    }
}

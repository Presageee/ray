using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.material
{
    class PanelMaterial : Material
    {
        public float scale;
        public PanelMaterial(float scale, float refectiveness)
        {
            this.scale = scale;
            this.reflectiveness = refectiveness;
            
        }
        public override ColorChannel calcColor(Ray3 ray, Vector3 position, Vector3 normal)
        {
            return Math.Abs(Math.Floor(position.x * this.scale) + 
                Math.Floor(position.z * this.scale)) % 2 > 1 ? new ColorChannel(0, 0, 0) : new ColorChannel(1, 1, 1);
        }
    }
}

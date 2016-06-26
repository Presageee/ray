using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class Union
    {
        public List<Base> list;

        public Union(List<Base> list)
        {
            this.list = list;
        }

        public InsertsectResult insertsect(Ray3 ray)
        {
            float minDistance = 100000000;
            InsertsectResult minCom = new InsertsectResult();
            int len = list.Count;
            for (int i = 0; i < len; i++)
            {
                InsertsectResult result = list[i].insertsect(ray);
                if (result.sphere != null && result.distance < minDistance)
                {
                    minDistance = result.distance;
                    minCom = result;
                }
            }
            return minCom;
        }
    }
}

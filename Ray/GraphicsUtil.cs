using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray
{
    class GraphicsUtil
    {
        private Graphics g;
        
        public GraphicsUtil(Graphics g)
        {
            this.g = g;
        }

        public void renderDepth(Sphere sphere,PrespectCamera camera, int depth, Bitmap bitmap, int width, int height)
        {
            camera.init();
            for (int i = 0; i < height; i++)
            {
                float sy = 1 - i / (float)height;
                for (int k = 0; k < width; k++)
                {
                    float sx = k / (float)width;
                    Ray3 ray = camera.GenerRay(sx, sy);
                    InsertsectResult insert = sphere.insertsect(ray);
                    if (insert.sphere != null && insert.distance > 0)
                    {
                        int dep = 255 - Math.Min((int)((insert.distance / depth) * 255), 255);
                        //Color color = Color.FromArgb(dep, dep, dep);
                        Color color = Color.FromArgb((int)((insert.normal.x + 1) * 128), (int)((insert.normal.y + 1) * 128),(int)((insert.normal.z + 1) * 128));
                        bitmap.SetPixel(k, i, color);
                    }
                }
            }
            this.g.DrawImage(bitmap, new Point(0, 0));
        }

        public void renderMulCom(Union union, PrespectCamera camera, int depth, Bitmap bitmap, int width, int height)
        {
            camera.init();
            for (int i = 0; i < height; i++)
            {
                float sy = 1 - i / (float)height;
                for (int k = 0; k < width; k++)
                {
                    float sx = k / (float)width;
                    Ray3 ray = camera.GenerRay(sx, sy);
                    InsertsectResult insert = union.insertsect(ray);
                    if (insert.sphere != null && insert.distance > 0)
                    {
                        int dep = 255 - Math.Min((int)((insert.distance / depth) * 255), 255);
                        //Color color = Color.FromArgb(dep, dep, dep);
                        Color color = Color.FromArgb((int)((insert.normal.x + 1) * 128), (int)((insert.normal.y + 1) * 128), (int)((insert.normal.z + 1) * 128));
                        bitmap.SetPixel(k, i, color);
                    }
                }
            }
            this.g.DrawImage(bitmap, new Point(0, 0));
        }

        public void renderMulComAndReflect(Union union, PrespectCamera camera, Bitmap bitmap, int width, int height, int reflectTime)
        {
            camera.init();
            for (int i = 0; i < height; i++)
            {
                float sy = 1 - i / (float)height;
                for (int k = 0; k < width; k++)
                {
                    float sx = k / (float)width;
                    Ray3 ray = camera.GenerRay(sx, sy);
                    ColorChannel channel = Reflect.calcReflectChannel(union, ray, reflectTime);
                    Color color = Color.FromArgb((int)(255 * channel.r) > 255 ? 255 : (int)(255 * channel.r),
                        (int)(255 * channel.g) > 255 ? 255 : (int)(255 * channel.g), (int)(255 * channel.b) > 255 ? 255 : (int)(255 * channel.b));
                    bitmap.SetPixel(k, i, color);
                }
            }
            this.g.DrawImage(bitmap, new Point(0, 0));
        }
    }
}

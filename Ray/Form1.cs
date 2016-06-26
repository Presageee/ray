using Ray.material;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = this.Width;
            int height = this.Height;
            Bitmap bitmap = new Bitmap(width, height);
            Color black = Color.FromArgb(0, 0, 0);
            Color write = Color.FromArgb(255, 255, 255);
            GraphicsUtil gu = new GraphicsUtil(g);
            Panel panel = new Panel(new Vector3(0, 1, 0), 0);
            panel.material = new PanelMaterial((float)0.1, (float)0.5);
            Sphere s1 = new Sphere(new Vector3(-10, 10, -10), 10);
            s1.material = new SphereMaterial(new ColorChannel((float)0.5, (float)0.5, (float)0.5), new ColorChannel((float)0.9, (float)0.1, (float)0.1), 16, (float)0.25);
            Sphere s2 = new Sphere(new Vector3(10, 10, -10), 10);
            s2.material = new SphereMaterial(new ColorChannel(1, 1, 0), new ColorChannel(1, 1, 0), 16, (float)0.25);
            Sphere s3 = new Sphere(new Vector3(0, -8, -10), 10);
            s3.material = new SphereMaterial(Constant.green, Constant.black, 16, (float)0.25);
            List<Base> list = new List<Base>();
            list.Add(panel);
            list.Add(s1);
            list.Add(s2);
            //list.Add(s3);
            gu.renderMulComAndReflect(new Union(list),
                new PrespectCamera(new Vector3(0, 5, 15), new Vector3(0, 0, -1), new Vector3(0, 1, 0), 90), bitmap, width, height, 1);
        }
        
    }
}

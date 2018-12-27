using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoDecorator.ConcreteClasses
{
    public class Photo: Form 
    {
        Image image;
        public Photo()
        {
            image = new Bitmap("jug.jpg");
            this.Text = "Lemonade";
            this.Paint += new PaintEventHandler(Drawer);
        }
        public virtual void Drawer(object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 30, 20);
        }
    }
}

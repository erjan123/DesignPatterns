using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using PhotoDecorator.Example2;

namespace PhotoDecorator.ConcreteClasses
{
    public class Photo2: Form, IPhoto
    {
        Image image;
        public Photo2()
        {
            image = new Bitmap("jug.jpg");
            Text = "Lemonade";
            Paint += new PaintEventHandler(Drawer);
        }
        public void Drawer(object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 30, 20);
        }
    }
}

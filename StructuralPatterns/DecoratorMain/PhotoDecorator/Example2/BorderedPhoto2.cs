using PhotoDecorator.Example2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDecorator.ConcreteClasses
{
    class BorderedPhoto2: Photo2
    {
        Photo2 photo;
        Color color;

        public BorderedPhoto2(Photo2 p, Color c)
        {
            photo = p;
            color = c;
        }
    
        public void Drawer2(object source, PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
        }
    }
}

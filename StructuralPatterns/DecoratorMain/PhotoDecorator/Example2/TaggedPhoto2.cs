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
    public class TaggedPhoto2 : Photo2
    {
        Photo2 photo;
        string tag;
        int number;
        static int count;
        List<string> tags = new List<string>();

        public TaggedPhoto2(Photo2 p, string t)
        {
            photo = p;
            tag = t;
            tags.Add(t);
            number = ++count;
        }

        public string ListTaggedPhotos()
        {
            string s = "Tags are: ";
            foreach (string t in tags) s += t + " ";
            return s;
        }

        public void Drawer2(object source, PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawString(tag,
            new Font("Arial", 16),
            new SolidBrush(Color.Black),
            new PointF(80, 100 + number * 20));
        }
    }
}

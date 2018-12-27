using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDecorator.Example2
{
    public interface IPhoto
    {
        void Drawer(object source, PaintEventArgs e);
    }
}

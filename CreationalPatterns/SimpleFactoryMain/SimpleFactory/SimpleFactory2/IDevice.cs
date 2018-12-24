using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory2
{
    public interface IDevice
    {
      string Name { get; set; }
      void ScreenSize();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory1
{
    public class SimpleFactory1
    {
        public object GetScreenSize(DeviceType deviceSize)
        {
            switch (deviceSize)
            {
                case DeviceType.Mobile:
                    return new Mobile();
                case DeviceType.Tablet:
                    return new Tablet();
                case DeviceType.DesktopHD:
                    return new DesktopHD();
                case DeviceType.Desktop4k:
                    return new Desktop4k();
                default:
                    return new ArgumentException();
            }
        }
    }
}

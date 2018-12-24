using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory2
{
    public class SimpleFactory
    {
        public IDevice GetDevice(Enum deviceType)
        {
            switch (deviceType)
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
                    return null;
            }
        }

    }
}

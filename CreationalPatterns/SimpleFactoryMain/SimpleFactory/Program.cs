using SimpleFactory.SimpleFactory2;
using System;
using System.Collections.Generic;
using smpf = SimpleFactory.SimpleFactory2;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var smpl = new smpf.SimpleFactory();
            List<IDevice> devices = new List<IDevice>();
            devices.Add(smpl.GetDevice(DeviceType.Mobile));
            devices.Add(smpl.GetDevice(DeviceType.Tablet));
            devices.Add(smpl.GetDevice(DeviceType.DesktopHD));
            devices.Add(smpl.GetDevice(DeviceType.Desktop4k));

            foreach(var d in devices)
            {
                d.ScreenSize();
            }

            Console.Read();
        }
    }
}

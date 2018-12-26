using SimpleFactory.SimpleFactory2;
using SimpleFactory.SimpleFactory3;
using System;
using System.Collections.Generic;
using smpf = SimpleFactory.SimpleFactory2;
using smpf1 = SimpleFactory.SimpleFactory1;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SimpleFactory 1 example

                smpf1.SimpleFactory1 deviceType = new smpf1.SimpleFactory1();

                var mobile = (smpf1.Mobile)deviceType.GetScreenSize(smpf1.DeviceType.Mobile);
                var tablet = (smpf1.Tablet)deviceType.GetScreenSize(smpf1.DeviceType.Tablet);
                var desktopHD = (smpf1.DesktopHD)deviceType.GetScreenSize(smpf1.DeviceType.DesktopHD);
                var desktop4k = (smpf1.Desktop4k)deviceType.GetScreenSize(smpf1.DeviceType.Desktop4k);
                mobile.ScreenSize();
                tablet.ScreenSize();
                desktopHD.ScreenSize();
                desktop4k.ScreenSize();

                Console.WriteLine();
                Console.WriteLine();

            #endregion

            #region SimpleFactory 2 example

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

            Console.WriteLine("\r\n");

            #endregion

            #region SimpleFactory 3 example

            List<IOrder> orders = new List<IOrder>()
                {
                    SimpleOrderFactory3.SubmitOrder(10, 10.90),
                    SimpleOrderFactory3.SubmitOrder(10, 10.90, 20),
                    SimpleOrderFactory3.SubmitOrder(10, 10, 10.90, 20)
                };

            foreach (var order in orders)
            {
               Console.WriteLine(order.CalculatePrice());
            }

            #endregion 

            Console.Read();
        }
    }
}

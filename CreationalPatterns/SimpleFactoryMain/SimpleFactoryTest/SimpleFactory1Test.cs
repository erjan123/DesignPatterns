using NUnit.Framework;
using SimpleFactory.SimpleFactory1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Check_If_New_Instance_Is_TypeIs_Mobile()
        {
            SimpleFactory1 smpl = new SimpleFactory1();
            var mobile = (Mobile)smpl.GetScreenSize(DeviceType.Mobile);
            Assert.IsTrue(mobile.GetType() == typeof(Mobile));
        }

        [Test]
        public void Check_If_New_Instance_Is_TypeIs_Tablet()
        {
            SimpleFactory1 smpl = new SimpleFactory1();
            var tablet = (Tablet)smpl.GetScreenSize(DeviceType.Tablet);
            Assert.IsTrue(tablet.GetType() == typeof(Tablet));
        }

        [Test]
        public void Check_If_New_Instance_Is_TypeIs_DesktopHD()
        {
            SimpleFactory1 smpl = new SimpleFactory1();
            var desktopHD = (DesktopHD)smpl.GetScreenSize(DeviceType.DesktopHD);
            Assert.IsTrue(desktopHD.GetType() == typeof(DesktopHD));
        }

        [Test]
        public void Check_If_New_Instance_Is_TypeIs_Desktop4k()
        {
            SimpleFactory1 smpl = new SimpleFactory1();
            var desktop4k = (Desktop4k)smpl.GetScreenSize(DeviceType.Desktop4k);
            Assert.IsTrue(desktop4k.GetType() == typeof(Desktop4k));
        }
    }
}
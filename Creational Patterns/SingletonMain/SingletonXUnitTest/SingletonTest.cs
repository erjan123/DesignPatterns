using System;
using Xunit;
using Singleton;

namespace SingletonXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Logger1 instance1 = Logger1.GetInstance;
            Logger1 instance2 = Logger1.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.counter++;
            Assert.Equal(instance1.counter, instance2.counter);

        }
    }
}

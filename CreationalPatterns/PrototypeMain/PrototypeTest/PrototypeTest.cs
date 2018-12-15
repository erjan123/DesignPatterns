using NUnit.Framework;
using Prototype;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PrototypeDancer1_Test_Clone()
        {
            PrototypeDancer1 salsaDancer = new PrototypeDancer1("Marc", "Salsa");
            PrototypeDancer1 newSalsaDancer = salsaDancer.Clone();

            Assert.AreNotEqual(salsaDancer, newSalsaDancer);
            newSalsaDancer.Name = "Tom";

            Assert.AreNotEqual(salsaDancer.Name, newSalsaDancer.Name);
            Assert.Pass();
        }

        [Test]
        public void PrototypeDancer2_Test_Clone()
        {
            PrototypeDancer2 salsaDancer = new PrototypeDancer2("Marc Anthony", "Salsa");
            PrototypeDancer2 newSalsaDancer = salsaDancer.Clone();

            Assert.AreNotEqual(salsaDancer, newSalsaDancer);
            newSalsaDancer.Name = "Brad Pitt";

            Assert.AreNotEqual(salsaDancer.Name, newSalsaDancer.Name);
            Assert.Pass();
        }
    }
}
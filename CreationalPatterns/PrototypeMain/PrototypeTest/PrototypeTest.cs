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

            Assert.AreNotSame(salsaDancer, newSalsaDancer);
            newSalsaDancer.Name = "Tom";

            Assert.AreNotEqual(salsaDancer.Name, newSalsaDancer.Name);
        }

        [Test]
        public void PrototypeDancer2_Test_Clone()
        {
            PrototypeDancer2 salsaDancer = new PrototypeDancer2("Marc Anthony", "Salsa");
            PrototypeDancer2 newSalsaDancer = salsaDancer.Clone();

            Assert.AreNotSame(salsaDancer, newSalsaDancer);
            newSalsaDancer.Name = "Brad Pitt";

            Assert.AreNotEqual(salsaDancer.Name, newSalsaDancer.Name);
        }

        [Test]
        public void PrototypeDancer3_Abstract_Class_Test_Clone()
        {
            PrototypeDancer3 ballroomDancer = new PrototypeDancer3("Kate", "Waltz");
            PrototypeDancer3 foxtrotDancer = ballroomDancer.Clone() as PrototypeDancer3;

            Assert.AreNotSame(ballroomDancer, foxtrotDancer);
            foxtrotDancer.DanceType = "Foxtrot";

            Assert.AreNotEqual(ballroomDancer, foxtrotDancer);
        }
    }
}
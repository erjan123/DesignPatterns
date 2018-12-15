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
        public void PrototypeDancer3_ReturnNewObject_Test_Clone_()
        {
            PrototypeDancer3 salsaDancer = new PrototypeDancer3("Marc Anthony", "Salsa");
            PrototypeDancer3 newSalsaDancer = salsaDancer.Clone();

            Assert.AreNotSame(salsaDancer, newSalsaDancer);
            newSalsaDancer.Name = "Brad Pitt";

            Assert.AreNotEqual(salsaDancer.Name, newSalsaDancer.Name);
        }

        [Test]
        public void PrototypeDancer4_Abstract_Class_Test_Clone()
        {
            PrototypeDancer4 ballroomDancer = new PrototypeDancer4("Kate", "Waltz");
            PrototypeDancer4 foxtrotDancer = ballroomDancer.Clone() as PrototypeDancer4;

            Assert.AreNotSame(ballroomDancer, foxtrotDancer);
            foxtrotDancer.DanceType = "Foxtrot";

            Assert.AreNotEqual(ballroomDancer, foxtrotDancer);
        }

        [Test]
        public void Person_Shallow_Copy_Test()
        {
            Person dancer = new Person();
            dancer.Name = "Irina";
            dancer.Age = 23;
            dancer.HomeAddress = new Address("PrincetonStreet",08512,"Princeton");

            Person newDancer = dancer.ShallowCopy();
            Assert.AreNotSame(dancer, newDancer);

            newDancer.HomeAddress.City = "Kiev";
            Assert.AreEqual(dancer.HomeAddress.City, newDancer.HomeAddress.City);

        }

        [Test]
        public void Person_Deep_Copy_Test()
        {
            Person dancer = new Person();
            dancer.Name = "Irina";
            dancer.Age = 23;
            dancer.HomeAddress = new Address("PrincetonStreet", 08512, "Princeton");

            Person newDancer = dancer.DeepCopy();
            Assert.AreNotSame(dancer, newDancer);

            newDancer.HomeAddress.City = "Kiev";
            Assert.AreNotEqual(dancer.HomeAddress.City, newDancer.HomeAddress.City);

        }
    }
}
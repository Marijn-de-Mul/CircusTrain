using CircusTrain;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CircusTrainTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Scenario1()
        {
            int maxWagons = 2; 

            Input.SmallCarnivore = 1; 
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 3;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario2()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 1;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 5;
            Input.MediumHerbivore = 2;
            Input.LargeHerbivore = 1;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario3()
        {
            int maxWagons = 4;

            Input.SmallCarnivore = 1;
            Input.MediumCarnivore = 1;
            Input.LargeCarnivore = 1;
            Input.SmallHerbivore = 1;
            Input.MediumHerbivore = 1;
            Input.LargeHerbivore = 1;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario4()
        {
            int maxWagons = 5;

            Input.SmallCarnivore = 2;
            Input.MediumCarnivore = 1;
            Input.LargeCarnivore = 1;
            Input.SmallHerbivore = 1;
            Input.MediumHerbivore = 5;
            Input.LargeHerbivore = 1;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario5()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 1;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 1;
            Input.MediumHerbivore = 1;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario6()
        {
            int maxWagons = 3;

            Input.SmallCarnivore = 3;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 2;
            Input.LargeHerbivore = 3;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario7()
        {
            int maxWagons = 13;

            Input.SmallCarnivore = 7;
            Input.MediumCarnivore = 3;
            Input.LargeCarnivore = 3;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 5;
            Input.LargeHerbivore = 6;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario8()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 0;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 5;
            Input.MediumHerbivore = 3;
            Input.LargeHerbivore = 1;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario9()
        {
            int maxWagons = 6;

            Input.SmallCarnivore = 1;
            Input.MediumCarnivore = 3;
            Input.LargeCarnivore = 2;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 0;
            Input.LargeHerbivore = 3;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario10()
        {
            int maxWagons = 8;

            Input.SmallCarnivore = 2;
            Input.MediumCarnivore = 2;
            Input.LargeCarnivore = 2;
            Input.SmallHerbivore = 5;
            Input.MediumHerbivore = 5;
            Input.LargeHerbivore = 5;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario11()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 0;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 1;
            Input.MediumHerbivore = 3;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario12()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 1;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 3;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario13()
        {
            int maxWagons = 2;

            Input.SmallCarnivore = 2;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 2;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }

        [TestMethod]
        public void Scenario14()
        {
            int maxWagons = 3;

            Input.SmallCarnivore = 2;
            Input.MediumCarnivore = 0;
            Input.LargeCarnivore = 0;
            Input.SmallHerbivore = 0;
            Input.MediumHerbivore = 6;
            Input.LargeHerbivore = 2;

            Assert.IsTrue(TrainTest.UnitTestStart() == maxWagons);
        }
    }
}
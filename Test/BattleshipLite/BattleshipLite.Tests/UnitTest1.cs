using NUnit.Framework;

namespace BattleshipLite.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void BasicEndGame()
        {
            Game currentGame = new Game();

            // Define a test input and output value:
            bool expectedResult = true;
            Boat battleship = new Boat()
            {
                this.length = 5,
                this.position = new Point(1,1),
                this.hits = 5,
                this.status = sunken;
            };

            Boat destroyerA = new Boat()
            {
                this.length = 4,
                this.position = new Point(1, 1),
                this.hits = 5,
                this.status = sunken;
            };

            Boat destroyerB = new Boat()
            {
                this.length = 4,
                this.position = new Point(1, 1),
                this.hits = 5,
                this.status = sunken;
            };

            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);

        }
    }
}
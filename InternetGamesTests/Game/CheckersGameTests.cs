using Microsoft.VisualStudio.TestTools.UnitTesting;
using InternetGames.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Game.Tests
{
    [TestClass()]
    public class CheckersGameTests
    {
        private CheckersGame TestGame;
        [TestInitialize]
        public void PreTestInit()
        {
            TestGame = new CheckersGame();
        }
        //test P1P1P1P1/1P1P1P1P/P1P1P1P1/8/8/1p1p1p1p/p1p1p1p1/1p1p1p1p/8 w 0 1
        //test P1P1P1P1/1P1P1P1P/P1P1P1P1/8/8/1p1p1p1p/p1p1p1p1p/1p1p1p1p w 0 1 
        [TestMethod()]
        public void GenerateBoardTest()
        {
        }
        [TestMethod()]
        public void GenerateBoardTooManyRowsTest()
        {

        }
        [TestMethod()]
        public void GenerateBoardToomanyColumnsTest()
        {

        }
        [TestMethod()]
        public void GenerateBoardIncompleteFENTest()
        {

        }

        [TestMethod()]
        public void InvertedDefaultFENTest()//would occur at the start of the game
        {
            string expectedInverted = "P1P1P1P1/1P1P1P1P/P1P1P1P1/8/8/1p1p1p1p/p1p1p1p1/1p1p1p1p w 0 1";
            string actualInverted = TestGame.InvertFEN(TestGame.GenerateFEN());
            Assert.AreEqual(expectedInverted, actualInverted);
        }

        [TestMethod()]
        public void InvertFENDifferentTest()//would occur somewhere mid game
        {
            string expectedInverted = "P1k5/1P3P1P/P1P3P1/5p2/8/1p3p1p/p1p3p1/1p1p3p r 1 15";
            string actualInverted = TestGame.InvertFEN("p3p1p1/1p3p1p/p1p3p1/8/2p5/1P3P1P/P1P3P1/5k1P r 1 15");
            Assert.AreEqual(expectedInverted, actualInverted);
        }
    }
}
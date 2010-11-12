using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.CreationalPatterns;

namespace Tests
{
    [TestClass]
    public class InitialMazeTest
    {
        [TestMethod]
        public void BasicCreateMazeTest()
        {
            Maze maze = MazeGame.CreateGameInitialSimple();
        }
    }
}

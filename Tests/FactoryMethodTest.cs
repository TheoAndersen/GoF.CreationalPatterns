using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.CreationalPatterns.FactoryMethod;
using GoF.CreationalPatterns;

namespace Tests
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void SimpleFactoryMethodTest()
        {
            FactoryMethodMazeGame mazeGame = new FactoryMethodMazeGame();

            Maze maze = mazeGame.CreateGame();

            Assert.IsInstanceOfType(maze.RoomNumber(1), typeof(Room));
        }

        [TestMethod]
        public void FactoryMethod_EnchantedMazeGame_CreateGame()
        {
            EnchantedFactoryMethodMazeGame mazeGame = new EnchantedFactoryMethodMazeGame();

            Maze maze = mazeGame.CreateGame();

            Assert.IsInstanceOfType(maze.RoomNumber(1), typeof(EnchantedRoom));
        }
    }
}

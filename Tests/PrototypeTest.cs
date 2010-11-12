using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.CreationalPatterns;
using GoF.CreationalPatterns.Prototype;
using GoF.CreationalPatterns.AbstractFactory;

namespace Tests
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void SimplePrototypeTest()
        {
            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new Room(), new Door(), new Wall());

            Maze maze = CreateMaze(simpleMazeFactory);

            Assert.IsInstanceOfType(maze.RoomNumber(1), typeof(Room));
        }

        [TestMethod]
        public void PrototypeTest_WithEnchantedRoom()
        {
            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new EnchantedRoom(new Spell()), new Door(), new Wall());

            Maze maze = CreateMaze(simpleMazeFactory);

            Assert.IsInstanceOfType(maze.RoomNumber(1), typeof(EnchantedRoom));
        }

        private Maze CreateMaze(MazeFactory factory)
        {
            Maze aMaze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);
            Door theDoor = factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.South, theDoor);
            r1.SetSide(Direction.East, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}

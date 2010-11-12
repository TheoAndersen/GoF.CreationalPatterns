using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.CreationalPatterns.Builder;
using GoF.CreationalPatterns;

namespace Tests
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void CreateMaze_FromStandardMazeBuilder()
        {
            MazeBuilder builder = new StandardMazeBuilder();

            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            Maze maze = builder.GetMaze();

            Assert.AreEqual(2, maze.rooms.Count());
        }

        [TestMethod]
        public void CreateMaze_FromCountingMazeBuilder()
        {
            CountingMazeBuilder builder = new CountingMazeBuilder();

            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            Assert.AreEqual(1, builder.Doors);
            Assert.AreEqual(2, builder.Rooms);
        }
    }
}

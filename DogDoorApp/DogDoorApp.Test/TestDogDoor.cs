using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DogDoorApp.Model;

namespace DogDoorApp.Test
{
    [TestClass]
    public class TestDogDoor
    {
        public DogDoor DoorObjectCreator()
        {
            return new DogDoor();
        }
        [TestMethod]
        public void TestDoorOpen()
        {
            DogDoor door = DoorObjectCreator();
            door.Open();
            Assert.AreEqual<bool>(true,door.OpenStatus);
        }

        [TestMethod]
        public void TestDoorClose()
        {
            DogDoor door = DoorObjectCreator();
            door.Close();
            Assert.AreEqual<bool>(false, door.OpenStatus);
        }
    }
}

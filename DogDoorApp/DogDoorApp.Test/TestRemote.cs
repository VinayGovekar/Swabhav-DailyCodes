using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogDoorApp.Model;

namespace DogDoorApp.Test
{
    [TestClass]
    public class TestRemote
    {
        [TestMethod]
        public void TestPressButtonForClosing()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            door.Open();
            remote.PressButton();
            Assert.AreEqual<bool>(false, door.OpenStatus);
        }
        [TestMethod]
        public void TestPressButtonForOpening()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            remote.PressButton();
            Assert.AreEqual<bool>(false, door.OpenStatus);
        }
    }
}

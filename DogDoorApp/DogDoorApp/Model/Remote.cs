using System.Threading;
namespace DogDoorApp.Model
{
    public class Remote
    {
        private DogDoor _door;
        public Remote(DogDoor door) {
            _door = door;
        }
        public void PressButton()
        {
            if (_door.OpenStatus == true) _door.Close();
            else
            {
                _door.Open();
                Thread.Sleep(3000);
                _door.Close();
            }
        }
    }
}

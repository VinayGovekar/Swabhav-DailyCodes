
namespace DogDoorApp.Model
{
    public class DogDoor
    {
        private bool _openStatus;
        public DogDoor()
        {
            _openStatus = false;
        }

        public void Open()
        {
            _openStatus = true;
        }
        public void Close()
        {
            _openStatus = false;
        }

        public bool OpenStatus { get { return _openStatus; } }
    }
}


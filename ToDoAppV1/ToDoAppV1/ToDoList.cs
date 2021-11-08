using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ToDoAppV1
{   [Serializable]
    class ToDoList
    {
        private string[] _toDoListArray = new string[20];
        private int _arrayCounter=0;
       public ToDoList(string filePath)
        {
            if (File.Exists(filePath))
            {
                this._toDoListArray = DeSerializeObject(filePath)._toDoListArray;
                this._arrayCounter = DeSerializeObject(filePath)._arrayCounter;
            }
        }
        public string[] ToDoListArray
        {
            get
            {
                return _toDoListArray;
            }
        }
        public void AddItem(string itemName)
        {
            _toDoListArray[_arrayCounter] = itemName;
            _arrayCounter += 1;
        }
        public void SerializeObject(string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.OpenWrite(filePath);
            bf.Serialize(fileStream,this);
            fileStream.Close();
        }
        public ToDoList DeSerializeObject(string filePath)
        {
            FileStream fileStream;
            ToDoList newObj = null;
            BinaryFormatter bf = new BinaryFormatter();
            fileStream = File.OpenRead(filePath);
            newObj = (ToDoList)bf.Deserialize(fileStream);
            fileStream.Close();
            return newObj;
        }

    }
}

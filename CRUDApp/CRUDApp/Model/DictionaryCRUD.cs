using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.Model
{
    class DictionaryCRUD:DataStructuresParent
    {
        private Dictionary<int, int> _numberDictionary = new Dictionary<int, int>();

        public DictionaryCRUD() {
            CreateDictionary();
        }
        private void CreateDictionary()
        {
            for (int i = 0; i < 3; i++) _numberDictionary.Add(i, (i + 1) * 10);
        }
        public void UpdateDictionary(int value, int newValue)
        {
            for(int i = 0; i < _numberDictionary.Count; i++)
            {
                if (_numberDictionary[i] == value) _numberDictionary[i] = newValue;
            }
        }
        public void DeleteValueInDictionary(int value)
        {
            for (int i = 0; i < _numberDictionary.Count; i++)
            {
                if (_numberDictionary[i] == value) _numberDictionary.Remove(i);
            }
        }

        public override object ReturnData()
        {
            return _numberDictionary;
        }
    }
}

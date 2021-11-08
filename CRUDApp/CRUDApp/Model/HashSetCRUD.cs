using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.Model
{
    class HashSetCRUD:DataStructuresParent
    {
        private HashSet<int> _numberSet = new HashSet<int>
        {
            10,10,20,30
        };


        public void UpdateSet(int newValue)
        {
            _numberSet.Add(newValue);
        }
        public void DeleteItemFromSet(int value)
        {
            _numberSet.Remove(value);
        }

        public override object ReturnData()
        {
            return _numberSet;
        }
    }
}

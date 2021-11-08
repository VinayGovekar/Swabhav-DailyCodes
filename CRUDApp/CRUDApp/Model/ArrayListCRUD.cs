using System;
using System.Collections;


namespace CRUDApp.Model
{
    class ArrayListCRUD:DataStructuresParent
    {
        private ArrayList _numberList = new ArrayList();
        public ArrayListCRUD()
        {
            SetArrayListData();
        }

        private void SetArrayListData()
        {
            for (int i = 10; i < 31; i += 10) _numberList.Add(i);
            _numberList.Add("Hello");
            _numberList.Add(10.23);
        }
        public void UpdateArrayList(int index,int newValue)
        {
            _numberList[index] = newValue;
        }
        public void DeleteArrayListElement(int value)
        {
            try
            {
                _numberList.Remove(value);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override object ReturnData()
        {
            return _numberList;
        }
    }
}

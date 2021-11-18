using System;
using System.Collections.Generic;

namespace CompositePatternFolderApp
{
    public class Folder:IStorageItem
    {
        private string _name;
        private static string _indentation = "";
        private List<IStorageItem> _children = new List<IStorageItem>();
        public Folder(string name)
        {
            _name = name;
        }
        public void AddItem(IStorageItem item)
        {
            _children.Add(item);
        }
        public void Display()
        {
            Console.WriteLine(_indentation+"{0}",_name);
            _indentation += "\t";
            foreach (var item in _children) item.Display();
            
        }

    }
}

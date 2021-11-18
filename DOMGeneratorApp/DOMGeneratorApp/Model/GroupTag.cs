using System;
using System.Collections.Generic;

namespace DOMGeneratorApp.Model
{
    public class GroupTag : ITag
    {
        private string _name;
        private string _description;
        private List<ITag> _tags = new List<ITag>();
        public GroupTag(string name) : this(name, "") { }
        public GroupTag(string name,string description)
        {
            _name = name;
            _description = description;
        }
        public void AddTag(ITag tag)
        {
            _tags.Add(tag);
        }
        public string Render(string htmlString)
        {
            htmlString += "<"+_name+">";
            if (_name == "p") htmlString += _description;
            foreach(var item in _tags)
            {
                htmlString = item.Render(htmlString);
            }
            htmlString += "</"+_name+">";
            return htmlString;
        }
    }
}

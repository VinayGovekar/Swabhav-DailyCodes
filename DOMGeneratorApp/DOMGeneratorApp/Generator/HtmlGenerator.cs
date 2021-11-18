using System;
using System.IO;

namespace DOMGeneratorApp.Generator
{
    public class HtmlGenerator
    {
        public void GenerateHtml(string htmlString,string fileName)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            File.WriteAllText(fileName,htmlString);
        }
    }
}

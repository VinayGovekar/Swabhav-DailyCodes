using System;

using DOMGeneratorApp.Model;
using DOMGeneratorApp.Generator;
using System.IO;

namespace DOMGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var htmlGenerator = new HtmlGenerator();

            var root = new GroupTag("div");
            
            var userNameDiv = new GroupTag("div");
            var userNameText = new GroupTag("p", "Username: ");
            userNameText.AddTag(new IndividualTag("input", "text"));
            userNameDiv.AddTag(userNameText);

            var passwordDiv = new GroupTag("div");
            var passwordText = new GroupTag("p", "Password: ");
            passwordText.AddTag(new IndividualTag("input", "password"));
            passwordDiv.AddTag(passwordText);

            root.AddTag(userNameDiv);
            root.AddTag(passwordDiv);
            root.AddTag(new IndividualTag("input","Submit"));

            Console.WriteLine(root.Render(""));
            htmlGenerator.GenerateHtml(root.Render(""), Directory.GetCurrentDirectory() + "//index.html");
            Console.ReadLine();
        }
    }
}

using System;
using System.IO;

namespace ProductShop.App
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var xmlString = File.ReadAllText("Xml/users.xml");

        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;

namespace test
{
    public class Program
    {
        

        static void Main(string[]args)
        {
            float timer = 0;
            string filepath = "G:\\Min enhet\\sparanu\\GDrive.csv";
            File.WriteAllText(filepath, timer.ToString());
            Console.WriteLine("");
            
        }




    }
}

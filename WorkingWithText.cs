using System;
using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class WorkingWithText
    {
        static string[] callsigns = new string[]
            {
                "Hussker",
                "StarBucks",
                "Appolo",
                "Boomer",
                "Bulldog",
                "Athena",
                "Hello",
                "Racetrack"
            };
        public void Write()
        {
            string textFile = Combine(CurrentDirectory, "stream.txt");
            StreamWriter text = File.CreateText(textFile);
            foreach (string item in callsigns)
            {
                text.WriteLine(item);
            }
            text.Close();
            WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes...");
            WriteLine(File.ReadAllText(textFile));
        }
    }
}

using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class WorkingWithDirectories
    {
        public void Create()
        {
            string userFolder = GetFolderPath(SpecialFolder.Personal);
            var customFolder = new string[]
            {
                userFolder, "Code","Chapter09", "newfolder"
            };
            string dir = Combine(customFolder);

            WriteLine($"Working with : {dir}");
            WriteLine($"Does it exists : {Exists(dir)}");

            WriteLine("Creating it ......");
            CreateDirectory(dir);

            WriteLine($"Does it exists : {Exists(dir)}");
            WriteLine("confirm the directory exists and then press enter ...");
            ReadLine();

            WriteLine("Deleting it .......");
            Delete(dir);
            WriteLine($"Does it exists : {Exists(dir)}");


        }
    }
}

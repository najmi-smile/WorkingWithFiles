using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputFileSystemInfo system = new OutputFileSystemInfo();
            WorkingWithDrives driveInfo = new WorkingWithDrives();

            //system.info();            
            driveInfo.Drives();
        }     
    }
}

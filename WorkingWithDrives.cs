using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class WorkingWithDrives
    {
        public void Drives()
        {
            WriteLine($"|--------------------------------|------------|---------|-------------------|--------------------|");
            WriteLine($"| NAME                           | TYPE       | FORMAT  | SIZE              | FREE SPACE         |");
            WriteLine($"|--------------------------------|------------|---------|-------------------|--------------------|");
            
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if(drive.IsReady)
                {
                    WriteLine($"| {drive.Name,-30} | {drive.DriveType,-10} | {drive.DriveFormat,-7} |{drive.TotalSize,18:N0} | {drive.AvailableFreeSpace,18:N0} |");
                }
                else
                {
                    WriteLine($"| {drive.Name,-30} | {drive.DriveType,-10} |");
                }
            }
            WriteLine($"|--------------------------------|------------|---------|-------------------|--------------------|");
        }
    }
}

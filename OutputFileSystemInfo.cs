using System;
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class OutputFileSystemInfo
    {
        public void info()
        {
            WriteLine($"Path.PathSeparator              : {PathSeparator}");
            WriteLine($"Path.DirectorySeparatorChar     : {DirectorySeparatorChar}");
            WriteLine($"Directory.GetCurrentDirectory() : {GetCurrentDirectory()}");
            WriteLine($"Environment.CurrentDirectory    : {CurrentDirectory}");
            WriteLine($"Environment.SystemDirectory     : {SystemDirectory}");
            WriteLine($"Path.GetTempPath()              : {GetTempPath()}");
            WriteLine($"Get Folder Path(Special Folder) ------------------------------------------------");
            WriteLine($"System                          : {GetFolderPath(SpecialFolder.System)}");
            WriteLine($"Application Data                : {GetFolderPath(SpecialFolder.ApplicationData)}");
            WriteLine($"My Documents                    : {GetFolderPath(SpecialFolder.MyDocuments)}");
            WriteLine($"Personal                        : {GetFolderPath(SpecialFolder.Personal)}");
        }
    }
}

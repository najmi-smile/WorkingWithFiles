﻿using static System.Console;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputFileSystemInfo system = new OutputFileSystemInfo();
            WorkingWithDrives driveInfo = new WorkingWithDrives();
            WorkingWithDirectories dir = new WorkingWithDirectories();
            WorkingWithText textWriter = new WorkingWithText();

            system.info();            
            driveInfo.Drives();
            //dir.Create();
            textWriter.Write();
        }     
    }
}


//C# Program to Calculate the Size of Folder

using System;

namespace CalculateSize_of_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'G:\\Work_02' is Folder Path
            string folderPath = Path.Combine("G:\\Work_02");

            // Check if the directory exists before proceeding
            if (Directory.Exists(folderPath))
            {
                DirectoryInfo dInfo = new DirectoryInfo(folderPath);

                long sizeOfDir = DirectorySize(dInfo, true);

                Console.WriteLine("Directory size in Bytes: {0:N0} Bytes", sizeOfDir);
                Console.WriteLine("Directory size in KB: {0:N2} KB", ((double)sizeOfDir) / 1024);
                Console.WriteLine("Directory size in MB: {0:N2} MB", ((double)sizeOfDir) / (1024 * 1024));
                Console.WriteLine("Directory size in GB: {0:N2} GB", ((double)sizeOfDir) / (1024 * 1024 * 1024));
             
            }
            else
            {
                Console.WriteLine("The specified directory does not exist.");
            }

            Console.ReadLine();
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            long totalSize = dInfo.EnumerateFiles().Sum(file => file.Length);

            if (includeSubDir)
            {
                totalSize += dInfo.EnumerateDirectories().Sum(dir => DirectorySize(dir, true));
            }

            return totalSize;
        }
    }
}

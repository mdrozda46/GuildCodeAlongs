using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************* Fun With Directory Info ***********");
            Console.WriteLine();
            //ShowWindowsDirectoryInfo();
            //ModifyDirectory();
            //RemoveDirectory();
            //ListDrives();
            //ListDriveInfo();
            //SimpleFileIO();
            FileStreamMethod();

            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("****** Directory Info ******");
            Console.WriteLine("Full Name: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("*************************");
        }

        static void ModifyDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("Current Directory: {0}", dir.FullName);

            dir.CreateSubdirectory("MyFolder");
        }

        static void RemoveDirectory()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@".\MyFolder");
                dir.Delete();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            
        }

        static void ListDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine(drive);
            }
        }

        static void ListDriveInfo()
        {
            DriveInfo[] myDrives = DriveInfo.GetDrives();

            foreach (var drive in myDrives)
            {
                Console.WriteLine("Name: {0}",drive.Name);
                Console.WriteLine("Type: {0}",drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine("Free space: {0}", drive.TotalFreeSpace);
                    Console.WriteLine("Drive format: {0}", drive.DriveFormat);
                    Console.WriteLine("Label: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            }
        }

        static void SimpleFileIO()
        {
            string[] myTasks =
            {
                "prep lecture",
                "upgrade my phone",
                "take back equipment",
                "eat dinner"
            };

            File.WriteAllLines(@".\tasks.txt",myTasks);

            foreach (string task in File.ReadAllLines(@".\tasks.txt"))
            {
                Console.WriteLine("To Do {0}",task);
            }
            {
                
            }
        }

        static void FileStreamMethod()
        {
            using (FileStream fStream = File.Open(@"MyMessage.dat", FileMode.Create))
            { 

                string msg = "Hello!";
                byte[] msgAsBytes = Encoding.Default.GetBytes(msg);

                //wrote the file
                fStream.Write(msgAsBytes, 0, msgAsBytes.Length);

                //reset our position in the file
                fStream.Position = 0;

                //read the file one byte at a time
                byte[] bytesFromFile = new byte[msgAsBytes.Length];
                for (int i = 0; i < msgAsBytes.Length; i++)
                {
                    bytesFromFile[i] = (byte) fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }

                Console.WriteLine();

                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));

            }
        }
    }

    
}

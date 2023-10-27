using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public static void CreateFile()
        {
            FileInfo fi = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("Created file");
            str.WriteLine("Hello");
            str.WriteLine("Welcome");
            Console.WriteLine("Entered text");
        }
        public static void WriteData()
        {
            FileStream fs = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new(fs);
            Console.WriteLine("Enter text to insert:");
            string? str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void ReadData()
        {
            FileStream fs = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new(fs);
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public static void CopyMoveFile()
        {
            FileInfo fi1 = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            fi1.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp\\Sample.txt");
            Console.WriteLine("Copied file");
            FileInfo fi2 = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt");
            fi2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp\\Sample1.txt");
            Console.WriteLine("Moved file");
        }
        public static void DeleteFile()
        { 
            FileInfo fi1 = new("C:\\Users\\Administrator\\Desktop\\Files\\Temp\\Sample.txt");
            fi1.Delete();
            Console.WriteLine("Deleted");
        }
        public static void FileProperties()
        {
            FileInfo fi1 = new("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            Console.WriteLine(fi1.Name);
            Console.WriteLine(fi1.FullName);
            Console.WriteLine(fi1.Length);
            Console.WriteLine(fi1.LinkTarget);
            Console.WriteLine(fi1.CreationTime);
            Console.WriteLine(fi1.CreationTimeUtc);
            Console.WriteLine(fi1.DirectoryName);
            Console.WriteLine(fi1.Attributes);
            Console.WriteLine(fi1.Directory);
            Console.WriteLine(fi1.LastWriteTime);
            Console.WriteLine(fi1.Extension);
            Console.WriteLine(fi1.Exists);

        }
    }
}

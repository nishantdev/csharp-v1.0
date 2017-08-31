using System;
using System.IO;
using static System.Console;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Test"; // Windows 

            Stream s = null;
            StreamWriter writer = null;


            try
            {
                s = File.Open(Path.Combine(path, "TestFile.txt"), FileMode.OpenOrCreate);
                

                switch (s)
                {
                    case FileStream writeableFile when s.CanWrite:
                        WriteLine("The stream is to a file that I can write to.");
                        writer = new StreamWriter(s);
                        writer.WriteLine("Test");
                        break;
                    case FileStream readOnlyFile:
                        WriteLine("The stream is to a read-only file.");
                        break;
                    case MemoryStream ms:
                        WriteLine("The stream is to a memory address.");
                        break;
                    default: // always evaluated last despite its current position 
                        WriteLine("The stream is some other type.");
                        break;
                    case null:
                        WriteLine("The stream is null.");
                        break;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine($"Could not find a part of the path: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occured: {ex.GetType()} says {ex.Message}");

            }
            finally
            {

                if (writer != null)
                {
                    writer.Dispose();
                    WriteLine("The writer's unmanaged resources have been disposed."); 
                }

                if (s != null)
                {
                    s.Dispose();
                    WriteLine("The file's unmanaged resources have been disposed."); 
                }

                Console.ReadKey(true);
            }
            
        }
    }
}
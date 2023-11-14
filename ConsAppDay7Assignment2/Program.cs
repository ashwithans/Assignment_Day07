using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsAppDay7Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create File");
                Console.WriteLine("2. Read File");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Delete File");

                Console.Write("Enter the operation number: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Create File
                        Console.Write("Enter the file name: ");
                        string createFileName = Console.ReadLine();
                        Console.Write("Enter the content to write: ");
                        string createFileContent = Console.ReadLine();
                        CreateFile(createFileName, createFileContent);
                        Console.WriteLine("File created successfully!");
                        break;

                    case 2:
                        // Read File
                        Console.Write("Enter the file name to read: ");
                        string readFile = Console.ReadLine();
                        string content = ReadFile(readFile);
                        Console.WriteLine($"File Content:\n{content}");
                        break;

                    case 3:
                        // Append to File
                        Console.Write("Enter the file name to append: ");
                        string appendFileName = Console.ReadLine();
                        Console.Write("Enter the content to append: ");
                        string appendContent = Console.ReadLine();
                        AppendToFile(appendFileName, appendContent);
                        Console.WriteLine("Content appended successfully!");
                        break;

                    case 4:
                        // Delete File
                        Console.Write("Enter the file name to delete: ");
                        string deleteFileName = Console.ReadLine();
                        DeleteFile(deleteFileName);
                        Console.WriteLine("File deleted successfully!");
                        break;

                    default:
                        Console.WriteLine("Invalid operation choice.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void CreateFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }

        static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        static void AppendToFile(string fileName, string content)
        {
            File.AppendAllText(fileName, content);
        }
        static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
            Console.ReadKey();
        }
    }
    
}

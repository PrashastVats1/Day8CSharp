using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day8_Assigment_FileHandling
{
    public class FileHandler
    {
        public static void CreateFile(string fName, string content)
        {
            try
            {
                File.WriteAllText(fName, content);
                Console.WriteLine("File created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while creating the file!!" + ex.Message);
            }
        }

        public static void ReadFile(string fName)
        {
            try
            {
                string content = File.ReadAllText(fName);
                Console.WriteLine($"Content of file: '{fName}' : ");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading the file!!" + ex.Message);
            }
        }

        public static void AppendToFile(string fName, string content)
        {
            try
            {
                File.AppendAllText(fName, content);
                Console.WriteLine("File appended successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while appending the file!!" + ex.Message);
            }
        }

        public static void DeleteFile(string fName)
        {
            try
            {
                File.Delete(fName);
                Console.WriteLine("File deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting the file!!" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Assigment_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an operation to perform on files");
                Console.WriteLine("1 -> Create a new file");
                Console.WriteLine("2 -> Read a file");
                Console.WriteLine("3 -> Append to a file");
                Console.WriteLine("4 -> Delete a file");
                Console.WriteLine("5 -> Exit the program");

                string choice = Console.ReadLine();
                
                if(int.TryParse(choice, out int option) && option >= 1 && option <=5) {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the file name");
                            string createFName = Console.ReadLine();
                            Console.WriteLine("Enter content to write in the file");
                            string contentWrite = Console.ReadLine();
                            FileHandler.CreateFile(createFName, contentWrite);
                            break;

                        case 2:
                            Console.WriteLine("Enter file name to be read");
                            string readFName = Console.ReadLine();
                            FileHandler.ReadFile(readFName);
                            break;

                        case 3:
                            Console.WriteLine("Enter file name to append");
                            string appendFName = Console.ReadLine();
                            Console.WriteLine("Enter the content to append in the file");
                            string contentAppended = Console.ReadLine();
                            FileHandler.AppendToFile(appendFName, contentAppended);
                            break;

                        case 4:
                            Console.WriteLine("Enter file name to be deleted");
                            string deleteFName = Console.ReadLine();
                            FileHandler.DeleteFile(deleteFName);
                            break;

                        case 5:
                            Console.WriteLine("Exiting the program");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input please enter correct choice");
                }
            }
            Console.ReadKey();
        }
    }
}

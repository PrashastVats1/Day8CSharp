using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace FileHandlingEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "D:\\Mphasis\\Live Session\\File Handling Stuff\\";
            //string fname;
            //Console.WriteLine("Enter file name");
            //fname = Console.ReadLine();
            //string fPath = path + fname;
            //if(File.Exists(fPath))
            //{
            //    Console.WriteLine("The file already exists");
            //}
            //else
            //{
            //    File.Create(fPath);
            //    Console.WriteLine("File Created!!");
            //}

            //Console.WriteLine("Enter file path");
            //string fPath = Console.ReadLine();
            //if(!File.Exists(fPath))
            //{
            //    Console.WriteLine("File not found");
            //}
            //else
            //{
            //    StreamWriter sw = File.AppendText(fPath);
            //    sw.WriteLine("Welcome to stream writing example");
            //    sw.Dispose();
            //    sw.Close();
            //    Console.WriteLine("Created and text is written");
            //}

            //StreamReader sr;
            //try
            //{
            //    string fpath = "D:\\Mphasis\\Live Session\\File Handling Stuff\\student_data.txt";
            //    sr = new StreamReader(fpath);
            //    string text = "";
            //    while ((text = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text);
            //    }
            //    sr.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!" + ex.Message);
            //}
            //finally { Console.ReadKey(); }

            //try
            //{
            //    string path = "D:\\Mphasis\\Live Session\\File Handling Stuff\\";
            //    Console.WriteLine("Enter file name to read out from");
            //    string fname = Console.ReadLine();
            //    string fPath = path + fname;
            //    if(File.Exists(fPath))
            //    {
            //        string[] lines = File.ReadAllLines(fPath);
            //        foreach(string line in lines)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //    else { Console.WriteLine("File does not exist"); }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!" + ex.Message);
            //}
            //finally { Console.ReadKey(); }

            //delete file method
            try
            {
                string path = "D:\\Mphasis\\Live Session\\File Handling Stuff\\";
                Console.WriteLine("Enter file name to read out from");
                string fname = Console.ReadLine();
                string fPath = path + fname;
                if (File.Exists(fPath))
                {
                    File.Delete(fPath); Console.WriteLine("File deleted permanently!!");
                }
                else { Console.WriteLine("File does not exist"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}

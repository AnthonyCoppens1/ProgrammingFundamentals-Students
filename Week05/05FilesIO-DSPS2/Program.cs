using System;
using System.IO;

namespace _05FilesIO_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a txt-file in bin-folder of this project
            //--> path = <proj folder>\bin\Debug\<framework>\

            StreamWriter sr = File.CreateText("file.txt");
            sr.WriteLine("This is a text file"); //writing text to the file and opening new line
            sr.Write("Hello"); //writing text to file, no new line
            sr.Write(" My name is Jean-Baptiste!");
            sr.Close();


            //make a file in different locations! BUT make sure folder tests exists in c:\
            sr = File.CreateText(@"C:\test\file.txt");
            sr.WriteLine("test file in a different location.");
            sr.Close();

            //create a file on dekstop
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //change .desktop to anything system specific
            string path = Path.Combine(desktopFolder, "file.txt"); //add file to system specific folder
            sr = File.CreateText(path);
            sr.WriteLine("Hello");
            sr.Close();


            //looks for a file and append
            if (File.Exists(path))
            {
                sr = File.AppendText(path); //opens up the stream to push code or text again
                sr.WriteLine("Testing more text to add.");
                sr.WriteLine("EVEN MOOOORE");
                sr.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                sr = File.AppendText(@"C:\test\file.txt"); //open up
                sr.WriteLine("HELLO");
                sr.Close();
            }


            //deleting text files from certain folders
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pathOfMusic = Path.Combine(musicFolder, "WEIRDFILE.txt");
            sr = File.CreateText(pathOfMusic);
            sr.Close();

            //DELETING STUFF --> keep in mind that you have to run the previous lines
            //before being able to delete it.
            if (File.Exists(pathOfMusic))
            {
                File.Delete(pathOfMusic);
            }



        }
    }
}
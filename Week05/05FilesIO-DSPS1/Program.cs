using System;
using System.IO;

namespace _05FilesIO_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a text file in a folder (bin) of this project.
            //path = <proj folder>\bin\Debug\<framework\...

            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("This is a text file."); //write text and open a new line
            stream.Write("Hello"); //write text and don't go to next line
            stream.Write(" My name is Jean-Baptiste");
            stream.Close(); //close off to prevent problems


            //first make sure folder "test" exists in c drive --> create a text file there
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("test file in a different location.");
            stream.Close();


            //create a file on your desktop
            //instead of desktop --> choose any system specific folder --> change SpecialFolder. x
            string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopfolder, "dekstopfile.txt");
            stream = File.CreateText(path);
            stream.WriteLine("Hello");
            stream.Close();

            if (File.Exists(path)) //check if the file exists --> in this case on dekstop named dekstopfile.txt
            {
                stream = File.AppendText(path); //opens up stream to push text again
                stream.WriteLine("testing more text");
                stream.WriteLine("Even more!");
                stream.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("Hellooooooo");
                stream.Close();
            }


            //delete text file from a certain folder
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pathOfMusic = Path.Combine(musicFolder, "file.txt");
            stream = File.CreateText(pathOfMusic);
            stream.Close();

            //delete the file that we created earlier --> RUN PREVIOUS LINES FIRST BEFORE DELETE
            if (File.Exists(pathOfMusic))
            {
                File.Delete(pathOfMusic);
            }
        }
    }
}
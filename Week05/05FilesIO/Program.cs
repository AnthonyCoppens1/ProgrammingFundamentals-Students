using System;
using System.IO;

namespace _05FilesIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tekstfile aanmaken in bin-folder in proj
            //path = <proj folder>\bin\Debug\<frameWork>

            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("Dit is een test-file!"); //tekst naar bestand geschreven en nieuwe lijn geopend
            stream.Write("Hello");
            stream.Write(" Mijn naam is Jean!");
            stream.Close();

            //zorg ervoor dat je een map 'test' in je c-schijf hebt staan
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("Test file in een andere locatie");
            stream.Close();

            //file op bureaublad
            string bureaubladfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string path = Path.Combine(bureaubladfolder, "randomBestand.txt");
            stream = File.CreateText(path);
            stream.WriteLine("Hallo");
            stream.Close();


            if (File.Exists(path))
            {
                stream = File.AppendText(path); //open stream en voeg tekst toe
                stream.WriteLine("We testen meer tekst");
                stream.WriteLine("NOG MEER!");
                stream.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("Het regent buiten!");
                stream.Close();
            }

            //delete txt-file van een bepaalde locatie
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pathOfMusic = Path.Combine(musicFolder, "file.txt");
            stream = File.CreateText(pathOfMusic);
            stream.WriteLine("MUZIEK");
            stream.Close();

            if (File.Exists(pathOfMusic))
            {
                File.Delete(pathOfMusic);
            }


        }


    }
}
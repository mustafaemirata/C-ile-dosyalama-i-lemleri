using System;
using System.IO;
namespace consoleApp

{
    class MetinBelgesi
    {
        static void Main(string[] args)
        {
            string filePath;
            // C:\Kullanıcılar\Emir\Masaüstü\metinn.txt
            filePath= @"C:\Users\Emir\Desktop\DENEMELER\yeniMetin2.txt";
            //FileStream fs = new FileStream(filePath,FileMode.Create);

            FileStream filestream = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(filestream);
            writer.WriteLine("1.satir...");
            writer.WriteLine("2.satir...");
            writer.WriteLine("3.satir...");

            writer.Flush();
            writer.Close();
            filestream.Close();
            Console.WriteLine("Dosya yazdirma islemi başarıyla gerçekleşti.");


        }
    }
}

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string sourcePath = Path.Combine(Environment.CurrentDirectory, "images"); // 圖片來源
            string destinationPath = Path.Combine(Environment.CurrentDirectory, "output"); //  圖片複製位置

            ImageProcess imageProcess = new ImageProcess();  
            imageProcess.Clean(destinationPath);

            Stopwatch sw = new Stopwatch();  // 
            sw.Start();

            await imageProcess.ResizeImages(sourcePath, destinationPath, 2.0);

            sw.Stop();

            Console.WriteLine($"花費時間: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}


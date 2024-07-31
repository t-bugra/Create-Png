using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using create_png.Class;
using System.Security.Cryptography.X509Certificates;

namespace create_png
{
    class program
    {
        static void Main(string[]args)
        {
            int width = 255;
            int height = 255;
            Bitmap bitmap = new Bitmap(width, height);

            IScale Scale;

            Console.WriteLine("RGB Scale için 1, Black Scale için 2, Grey Scale için 3'e basınız:");
            string button_clik = Console.ReadLine();

            switch (button_clik)
            {
                case "1":
                    Scale = new Rgbscale();
                    break;
                case "2":
                    Scale = new Blackscale();
                    break;
                case "3":
                    Scale = new Greyscale();
                    break;
                default:
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz.");
                    return;
            }

            Scale.Render(bitmap);

            bitmap.Save(@"C:\Users\tbugr\OneDrive\Masaüstü\imagem.png"); // Bitmap'i kaydetme

        }
    }
    interface IScale
    {
     void Render (Bitmap bmp);

    }
}



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
            Console.WriteLine("Random RGB Scale için 1");
            Console.WriteLine("Black Scale için 2");
            Console.WriteLine("Grey Scale için 3");
            Console.WriteLine("RGB Scale için 4");
            Console.WriteLine("Random Black scale için 5'i Tuşlayınız");
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
                    case "4":
                        Scale = new Rgb_deneme();
                    break;
                    case "5":
                        Scale = new Randomblackscale();
                    break;
                default:
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz.");
                    Console.ReadLine();
                    return;
            }

            Scale.Render(bitmap);

            bitmap.Save(@"C:\Users\tbugr\OneDrive\Masaüstü\imagescale.png"); // Bitmap'i kaydetme

        }
    }
    interface IScale
    {
     void Render (Bitmap bmp);

    }
}



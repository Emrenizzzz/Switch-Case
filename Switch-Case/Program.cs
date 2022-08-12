using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expression
            int mounth = DateTime.Now.Month;

            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız");
                    break ;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız");
                    break;

                default:
                    Console.WriteLine("Yanlış değer girdiniz");
                    break;
            }

            switch (mounth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;

                default:
                    break;
            }
        }
    }
}

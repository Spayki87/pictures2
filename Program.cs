using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_картинок
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int pictures = 52;
            int filledRows = pictures / picturesInRow;
            Console.WriteLine("У вас получилось " + filledRows + " заполненых рядов.");
            int remainingPictures = pictures % picturesInRow;
            Console.WriteLine("У вас не влезла " + remainingPictures + " картинок.");
        }
    }
}

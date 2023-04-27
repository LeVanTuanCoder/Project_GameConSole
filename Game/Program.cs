using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten cua ban: ");
            string playerName = Console.ReadLine();

            Game game = new Game(playerName);
            game.Play();
            Console.ReadKey();
        }
    }
}

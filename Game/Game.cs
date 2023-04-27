using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        private HumanPlayer humanPlayer;
        private ComputerPlayer computerPlayer;

        public Game(string humanName)
        {
            humanPlayer = new HumanPlayer { Name = humanName };
            computerPlayer = new ComputerPlayer { Name = "May" };
        }

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Bat dau choi Bao, Keo, Bua!");
            humanPlayer.MakeChoice();
            computerPlayer.MakeChoice();
            Console.WriteLine("{0} chon {1}.", humanPlayer.Name, humanPlayer.Choice);
            Console.WriteLine("{0} chon {1}.", computerPlayer.Name, computerPlayer.Choice);

            if (humanPlayer.Choice == computerPlayer.Choice)
            {
                Console.WriteLine("Hoa !");
            }
            else if ((humanPlayer.Choice == "bao" && computerPlayer.Choice == "bua") ||
                     (humanPlayer.Choice == "keo" && computerPlayer.Choice == "bao") ||
                     (humanPlayer.Choice == "bua" && computerPlayer.Choice == "keo"))
            {
                Console.WriteLine("{0} chien thang!", humanPlayer.Name);
            }
            else
            {
                Console.WriteLine("{0} chien thang!", computerPlayer.Name);
            }

            Console.Write("An phim bat ky de tiep tuc hoac Esc de thoat...");
            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Play();
            }
        }
    }
}

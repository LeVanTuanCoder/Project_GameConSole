using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class HumanPlayer : Player
    {
        public override void MakeChoice()
        {
            Console.Write("Chao {0}, hay nhap lua chon cua ban (bao, keo, bua): ", Name);
            Choice = Console.ReadLine().ToLower();
            while (Choice != "bao" && Choice != "keo" && Choice != "bua")
            {
                Console.Write("Sai lua chon. hay nhap bao, keo hoac bua: ");
                Choice = Console.ReadLine().ToLower();
            }
        }
    } 
}

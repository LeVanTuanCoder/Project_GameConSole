using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ComputerPlayer : Player
    {
        public override void MakeChoice()
        {
            string[] choices = { "bao", "keo", "bua" };
            Choice = choices[new Random().Next(choices.Length)];
        }
    }
}

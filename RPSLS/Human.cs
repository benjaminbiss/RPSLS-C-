using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player_Form
    {
        public Human(string name, int score)
        {
            this.name = name;
            this.score = score;
            Console.WriteLine("{0}'s score is {1}", name, score);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player_Form
    {
        public int score;
        public string name;
        public Player_Form()
        {
            
        }
        public void IncreaseScore()
        {
            score += 1;
        }
    }
}

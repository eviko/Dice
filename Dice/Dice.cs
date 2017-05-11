using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon1
{
    class Dice
    {
        private Random r { get; set; }

        public Dice()
        {
            r = new Random();
        }

        public string Output(int Min, int Max)
        {

            return r.Next(Min, Max).ToString();
        }

    }
}

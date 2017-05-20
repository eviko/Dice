using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon1
{
    class Program
    {
        //ερωτήματα 1,2
        static void Main(string[] args)
        {
            int Min = 1;
            int Max = 7;
            Console.WriteLine("Press a key ");
            string UsersPressKey = Console.ReadLine().ToUpper();
            while (UsersPressKey != Char.ToUpper('q').ToString())
            {
                if (UsersPressKey == Char.ToUpper('o').ToString())
                    Min = 4;

                Dice Dice1 = new Dice();
                Dice Dice2 = new Dice();
                string number1 = Dice1.Output(Min, Max);

                string number2 = Dice2.Output(Min, Max);
                Console.WriteLine(number1 + " " + number2);
                UsersPressKey = Console.ReadLine().ToUpper();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon4
{
    class Program
    {
        //ερώτημα 4
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 0;
            int AmountOfDices = 0;
            try
            {
                Min = GetNumberFromUser("Give me the minimum:");
                Max = GetNumberFromUser("Give me the maximum:");
                AmountOfDices = GetNumberFromUser("Give me the amount of dices:");
            }
            catch (FormatException e)
            {
                ReportErrorToUser("One of the inputs where not numbers", e);
                return;
            }
            catch (OverflowException e)
            {
                ReportErrorToUser("One of the numbers is too big", e);
                return;
            }
            if (Min >= Max || AmountOfDices <= 0)
            {
                ReportErrorToUser("One of the inputs where not numbers", null);
                return;
            }
            Console.WriteLine("Press a key ");
            string UsersPressKey = Console.ReadLine().ToUpper();
            ArrayList ListOfDices = new ArrayList();
            int count = 0;
            while (UsersPressKey != Char.ToUpper('q').ToString())
            {
                ListOfDices.Clear();
                if (UsersPressKey == Char.ToUpper('o').ToString())
                {
                    Min = 4;
                    count++;
                }
                for (int i = 0; i < AmountOfDices; i++)
                    ListOfDices.Add(new Dice());
                foreach (Dice d in ListOfDices)
                {
                    string number = d.Output(Min, Max);
                    Console.WriteLine(number + " ");
                }
                UsersPressKey = Console.ReadLine().ToUpper();
            }
        }

        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            string num = Console.ReadLine();
            return Convert.ToInt32(num);
        }
        static void ReportErrorToUser(string message, Exception e)
        {
            if (e != null)
                Debug.WriteLine(e.Message);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}

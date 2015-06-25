using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            fingerGuessingGame Result = new fingerGuessingGame();
            Console.Write("請輸入你要出的招:1.剪刀,2.石頭,3.布 ");
            Result.UserInput = int.Parse(Console.ReadLine());
            int person1 = Result.UserInput;
            int person2 = Result.NpcInput;
            Result.GetResult(person1, person2);
        }
    }
}
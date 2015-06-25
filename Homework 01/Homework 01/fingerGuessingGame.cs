using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class fingerGuessingGame
    {
        private int userInput;
        private int npcInput;

        public int UserInput
        {
            get { return userInput; }
            set { userInput = value; }
        }

        public int NpcInput
        {
            get
            {
                Random npcInput = new Random();
                return npcInput.Next(1, 4);
            }
        }

        public void GetResult(int userInput, int npcInput)
        {
            string message = "第一個人出{0}, 第二個人出{1}, 結果{2}";
            string result;
            if (userInput == npcInput)
            {
                result = "平手";
            }
            else if ((userInput == 1 && npcInput == 2) || (userInput == 2 && npcInput == 1))
            {
                result = "石頭贏了";
            }
            else if ((userInput == 1 && npcInput == 3) || (userInput == 3 && npcInput == 1))
            {
                result = "剪刀贏了";
            }
            else
            {
                result = "輸入錯誤";
            }
            message = string.Format(message, userInput, npcInput, result);
            Console.WriteLine(message);
        }
    }
}
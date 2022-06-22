using System;

namespace _22JunePracticw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nece dene car elave edeceksen?");
            string answerStr = "";
            int answer;
            for (; ; )
            {
                answerStr = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(answerStr) && int.TryParse(answerStr, out answer))
                {
                    break;
                }
            }
            for (int i = 0; i < answer; i++)
            {
                Console.WriteLine($"{i+1}. masinin adini elave ele");
                string answerName;
                for (; ; )
                {
                    answerName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(answerName))
                    {
                        break;
                    }
                }
                string answerDurationStr;
                TimeSpan answerDuration;
                for (; ; )
                {
                    answerDurationStr = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(answerDurationStr) && TimeSpan.TryParse(answerDurationStr, ))
                    {
                        break;
                    }
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;

namespace _22JuneHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            string answercount = "";
            InputAnswer:
            int f = 0;
            for (; ; )
            {
                Console.WriteLine("nece dene olsun exam sayi");
                answercount = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(answercount))
                {
                    break;
                }
            }
            bool checkAnswer = int.TryParse(answercount, out int answerCountInt);

            if (checkAnswer)
            {
                for (int i = 0; i < answerCountInt; i++)
                {
                    Console.Write("examin studentinin adini daxil edin.......");
                    string answerStudent = "";
                    for (; ; )
                    {
                        answerStudent = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(answerStudent))
                        {
                            break;
                        }
                        Console.WriteLine("sehv daxil eledin bir de ele");
                    }
                    Console.Write("examin subjectinin adini yaz gorum .......");
                    string answerSubject = "";
                    for (; ; )
                    {
                        answerSubject = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(answerSubject))
                        {
                            break;
                        }
                        Console.WriteLine("sehv daxil eledin bir de ele");
                    }
                    Console.Write("examin pointini daxil ele.....");
                    string answerPoint = "";
                    double answerPointDouble;
                    for (; ; )
                    {
                        
                        answerPoint = Console.ReadLine();

                        if (double.TryParse(answerPoint, out answerPointDouble))
                        {
                            break;
                        }
                        Console.WriteLine("sehv daxil eledin bir de ele");
                    }
                    string answerStartDateString = "";
                    DateTime answerStartDate;
                    for (; ; )
                    {
                        Console.Write("ne vaxt basliyib imtahana?...");
                        answerStartDateString = Console.ReadLine();

                        if (DateTime.TryParse(answerStartDateString, out answerStartDate))
                        {
                            break;
                        }
                        Console.WriteLine("sehv daxil eledin bir de ele");
                    }
                    string answerEndDateString = "";
                    DateTime answerEndDate;
                    for (; ; )
                    {
                        Console.Write("ne vaxt qurtarib imtahani?...");
                        
                        if (DateTime.TryParse(answerEndDateString, out answerEndDate) && answerEndDate > answerStartDate)
                        {
                            break;
                        }
                        Console.WriteLine("sehv daxil eledin bir de ele");
                    }

                    Exam exam = new Exam(answerStartDate, answerEndDate)
                    {
                        Point = answerPointDouble,
                        Student = answerStudent,
                        Subject = answerSubject
                    };

                    exams.Add(exam);
                    Console.WriteLine("exam elave olundu ");

                }
                

            }
            else
            {
                Console.WriteLine("qaqas duzgun yaz sayi bir de yoxla");
                goto InputAnswer;
            }



            List<Exam> searchedExams = exams.FindAll(x => x.Point > 50);
            foreach (var item in searchedExams)
            {
                Console.WriteLine($"{item.Student} {item.Subject} - {item.Point} bal alib");
            }

            

                
        }
    }
}


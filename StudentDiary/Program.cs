using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
                        
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);
            diary.AddRating(1);
            diary.AddRating(2.5f);
            diary.AddRating(7.3f);
            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            DiaryStatistics stats = diary.ComputeStatistics();


            Console.WriteLine("Średnia ocena: " + stats.averageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.maxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.minGrade);

            Diary diary2 = new Diary();

            diary2.AddRating(4);
            diary2.AddRating(7.5f);
            diary2.AddRating(5.7f);
            diary2.AddRating(2);
            diary2.AddRating(1.5f);
            diary2.AddRating(8.3f);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia ocena: " + stats.averageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.maxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.minGrade);


            //for (; ;)
            //{
            //    Console.WriteLine("Podaj ocenę z zakresu 1.0 - 10.0");

            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(), out rating);

            //    if (rating == 11)
            //    {
            //        break;
            //    }

            //    if (result)         //To samo co: if (result == true)
            //    {
            //        if (rating >= 0 && rating <= 10)
            //        {
            //            diary.AddRating(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Liczba poza zakresem.");
            //        }
            //    }
            //}

            //Console.WriteLine("Średnia twoich ocen to: " + diary.CalculateAverage());
            //Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            //Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            //Console.ReadKey();
        }
    }
}

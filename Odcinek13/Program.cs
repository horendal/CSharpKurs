﻿using StudentDiary;
using System;

namespace Odcinek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3f);
            diary.AddRating(5f);
            diary.AddRating(11);

            
            Console.WriteLine(Diary.maxGrade);

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();
            Diary diary6 = new Diary();

            Console.WriteLine(Diary.Count);
            Console.WriteLine(diary.Count2);
            Console.WriteLine(diary5.Count2);

            DiaryStatistics stats = diary.ComputeStatistics();
        }
    }
}

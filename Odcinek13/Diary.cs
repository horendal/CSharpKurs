using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()      //konstruktor
        {
            ratings = new List<float>();
            Count++;
            Count2++;
        }
        
        // Stan (zmienne - pola)
        //List<float> ratings = new List<float>();    //lista zmiennych typu float (oceny)
        List<float> ratings;

        public static float minGrade = 0;
        public static float maxGrade = 10;
        public static long Count = 0;
        public long Count2 = 0;

        // Zachowania
        /// <summary>
        /// Dodaje oceny do listy
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)     
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float suma = 0f;

            foreach (var rating in ratings)
            {
                suma += rating;     //to samo co: sum = sum + rating;
            }

            stats.averageGrade = suma / ratings.Count();
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();

            return stats;
        }

        /// <summary>
        /// Oblicza średnią ocen z listy.
        /// </summary>
        /// <returns></returns>
        //public float CalculateAverage()
        //{
        //    float suma = 0, avg = 0;
                
        //    foreach (var rating in ratings)
        //    {
        //        suma += rating;     //to samo co: sum = sum + rating;
        //    }
        //    avg = suma / ratings.Count();
        //    return avg;
        //}

        /// <summary>
        /// Podaje najwyższą ocnę z listy.
        /// </summary>
        /// <returns></returns>
        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        /// <summary>
        /// Podaje najniższą ocenę z listy.
        /// </summary>
        /// <returns></returns>
        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}
    }
}

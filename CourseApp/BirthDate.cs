using System;

namespace CourseApp
{
     public class BirthDate
     {
         private int year;
         private int month;
         private int day;

         public BirthDate()
        : this(1995, 9, 19)
        {
        }

         public BirthDate(int year, int month, int day)
         {
             Year = year;
             Month = month;
             Day = day;
         }

         public int Year
         {
             get
             {
                 return this.year;
             }

             set
             {
                if (value > DateTime.Now.Year || value == 0)
                {
                throw new System.Exception($"Hey! It should be before or at least in {DateTime.Now.Year}");
                }
                else
                {
                this.year = value;
                }
             }
         }

         public int Month
         {
             get
             {
                 return this.month;
             }

             set
             {
                if (value > 12 || value == 0)
                {
                throw new System.Exception($"Nope! There's no {value}-th month!");
                }
                else
                {
                this.month = value;
                }
             }
         }

         public int Day
         {
             get
             {
                 return this.day;
             }

             set
             {
                if (value > 31 || value == 0)
                {
                throw new System.Exception($"Are you nuts?! Day {value} cannot be on our planet!");
                }
                else
                {
                this.day = value;
                }
             }
         }

         public int CalcAge(int year)
         {
             int year1 = DateTime.Now.Year - year;
             int month1 = DateTime.Now.Month - month;
             int day1 = DateTime.Now.Day - day;
             if (year < 0)
             {
                 throw new SystemException($"Errrr...that year has not even come....");
             }

             if (year1 == 0 && month1 == 0 && day1 == 0)
             {
                 throw new SystemException($"Hmmmm....today is, like, the same date...");
             }
             else if (year1 != 0 || month1 != 0 || day1 != 0)
             {
                 string year2 = Convert.ToString(year1);
                 string month2 = Convert.ToString(month1);
                 string day2 = Convert.ToString(day1);
                 Console.WriteLine($"Full years - {year2}, full months - {month2}, full days - {day2}");
             }

             return year;
         }
     }
}
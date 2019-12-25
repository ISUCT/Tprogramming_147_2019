using System;

namespace CourseApp
{
    public abstract class Media
    {
      public Media(int year, string name, string country)
        {
         Name = name;
         Year = year;
         Country = country;
        }

      public string Name { get; set; }

      public string Country { get; set; }

      public virtual int Year { get; set; }

      public abstract string Check();

      public abstract string Mark(int mark);

      public abstract string Send(string who);

      public new abstract string ToString();

      public virtual string Za_Warudo()
      {
        return "Toki Wa Tomare!";
      }
    }
}
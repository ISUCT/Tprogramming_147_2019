using System;

namespace CourseApp
{
    public class Music : Media
    {
        private int year;

        public Music()
        : this(10, "No title", "No country")
        {
        }

        public Music(int year, string name, string country)
        : base(year, name, country)
        {
        }

        public override int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value < 0 || value > DateTime.Now.Year)
                {
                    throw new System.Exception($"Production year should be between 0 and {DateTime.Now.Year}");
                }
                else
                {
                    this.year = value;
                }
            }
        }

        public override string Check()
        {
        return $"I'm listening a song, named {Name}, which came out in {Year} from {Country}";
        }

        public override string Mark(int mark)
        {
           switch (mark)
           {
               case 1:
               return $"{Name} is a piece of trash, because i can't explain it other way... ";

               case 2:
               return $"Well, {Name} pretty good, but it could be better.";

               case 3:
               return $"{Name} is a great song! You should really listen it too!";

               default:
               return "Can't help, i didn't listen this music, sorry";
           }
        }

        public override string Send(string who)
        {
            return $"Hi {who}, can you check {Name}({Year}) to lisen? I want you to tell me something about it as a music expert";
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Год: {Year}, Страна: {Country}";
        }
    }
}
using System;

namespace CourseApp
{
    public class City
    {
        private int pop;

        public City()
        : this(0, "Unitiled", "Unnamed")
        {
        }

        public City(int pop, string country, string name)
        {
            Pop = pop;
            Country = country;
            Name = name;
        }

        public string Country { get; set; }

        public string Name { get; set; }

        public int Pop
        {
            get
            {
                return this.pop;
            }

            set
            {
                if (value >= 0)
                {
                    this.pop = value;
                }
                else
                {
                    Console.WriteLine("Population should be > 0.");
                }
            }
        }

        public string View()
        {
        return @"
▐▌▐▐▄▄▄▐███▌▄███▄▐▌▌
▐██▐█▄█▐▌▌▐▌█▄█▄█▐▌█▌
▐▄██▄█▐▐▌▌▐▌█▄█▄█▐▌▌█▌
▐█▄██▐▐▐▌▌▐▌█▄█▄█▐▌▌▌█
██████████████████████
";
        }
    }
}
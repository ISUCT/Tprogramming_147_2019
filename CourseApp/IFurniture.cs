using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public interface IFurniture
    {
        double Weight { get; set; }

        double Height { get; set; }

        string Color { get; set; }

        int CountLegs { get; set;  }

        void Build();
    }
}

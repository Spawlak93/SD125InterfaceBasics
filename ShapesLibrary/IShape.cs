using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    //Interfaces establish rules for classes that implement them
    //Interfaces provide information for external use
    //used to set requirements
    public interface IShape
    {
        string Name { get; }

        void Draw();

        double CalculateArea();
    }
}
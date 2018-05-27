using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public class Shape
    {
        public int Size;
    }
    public class Circle : Shape
    {
        public Circle(int size)
        {
            Size = size;
        }
    }
    public class Rect : Shape
    {
        public Rect(int size)
        {
            Size = size;
        }
    }
}

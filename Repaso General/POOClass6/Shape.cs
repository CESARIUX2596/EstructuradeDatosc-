﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POOClass6
{
    //Para Explicar Polimofismo
    class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Lab8_v2
{
    public class Ink
    {
        public string Color { get; set; }
        public int Level { get; set; }
        public Ink(string color,int level)
        {
            Color = color;
            Level = level;
        }
    }
}

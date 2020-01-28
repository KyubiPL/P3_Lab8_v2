using System;

namespace P3_Lab8_v2

{
    public class OutOfInkEventArgs : EventArgs
    {
        public OutOfInkEventArgs(string color)
        {
            Color = color;
        }
        public string Color { get; set; }
    }
}
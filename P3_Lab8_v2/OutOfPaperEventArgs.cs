using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Lab8_v2
{
    public class OutOfPaperEventArgs : EventArgs
    {
        public OutOfPaperEventArgs(int PNumber)
        {
            this.PNumber = PNumber;
        }

        public int PNumber { get; set; }
    }
}

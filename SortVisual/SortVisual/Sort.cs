using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisual
{
    interface Sort
    {
        void DoWork(int[] TheArray, Graphics g, int MaxVal);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_gui
{
    public class Lingkaran
    {
        public int x;
        public int y;
        public string value;
        public Brush brush;
        public Lingkaran(int x, int y, string value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
            brush = new SolidBrush(Color.Black);
        }
    }
}

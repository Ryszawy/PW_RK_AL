﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Board
    {
        private int _width;
        private int _height;

        public Board(int width, int height)
        {
            this._width = width;
            this._height = height;
        }
        
        public int Width 
        { 
            get { return _width; } 
        }
        public int Height 
        { 
            get { return _height; } 
        }
    }
}

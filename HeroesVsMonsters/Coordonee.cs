﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesVsMonsters
{
    public class Coordonee
    {
        private int _X, _Y;

        public int X
        {
            get { return _X; }
            private set { _X = value; }
        }

        public int Y
        {
            get { return _Y; }
            private set { _Y = value; }
        }

        public Coordonee(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Space
{
    public class MetricSpace
    {

        private int _minX;
        private int _minY;
        private int _maxX;
        private int _maxY;

        public MetricSpace(Coordinates MinCoordinates, Coordinates MaxCoordinates)
        {
            _minX = MinCoordinates.Pos_X;
            _minY = MinCoordinates.Pos_Y;
            _maxX = MaxCoordinates.Pos_X;
            _maxY = MaxCoordinates.Pos_Y;
        }

        public bool IsInside(int x, int y)
        {
            return x >= _minX && x <= _maxX && y >= _minY && y <= _maxY;
        }

    }
}

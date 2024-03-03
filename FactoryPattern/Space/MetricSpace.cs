using System;
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

        public MetricSpace(int minX, int minY, int maxX, int maxY)
        {
            _minX = minX;
            _minY = minY;
            _maxX = maxX;
            _maxY = maxY;
        }

        public bool IsInside(int x, int y)
        {
            return x >= _minX && x <= _maxX && y >= _minY && y <= _maxY;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ColoredBalls
{
    internal class Ball
    {
        int _size;
        Color _color;
        int _numThrown;

        public Ball(int size, Color c)
        {
            _size = size;
            _color = c;
            _numThrown = 0;
        }

        public void Pop()
        {
            _size = 0;
        }

        public void Throw()
        {
            if (_size != 0)
                ++_numThrown;
        }

        public int NumberOfThrown()
        {
            return _numThrown;
        }
    }
}

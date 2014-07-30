using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculator
    {
        public SimpleCalculator()
        {
            Reset();      
        }

        public void Reset()
        {
            _p1 = 0;
            _p2 = 0;
        }

        public void Enter(string text)
        {
            switch (text)
            {
                case "+": _p2 = (Int16) (_p1 + _p2); break;
                case "-": _p2 = (Int16) (_p1 - _p2); break;
                case "*": _p2 = (Int16) (_p1 * _p2); break;
                case "/": _p2 = (Int16) (_p1 / _p2); break;
                default: _p1 = _p2; _p2 = Convert.ToInt16(text); break;
            }
        }

        public Int16 Result
        {
            get { return _p2; }
        }

        private Int16 _p1;
        private Int16 _p2;
        private Int16 _result;
    }
}

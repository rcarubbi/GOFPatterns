using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Number : Expression
    {
        private int _number;

        public Number(int number)
        {
            _number = number;

        }
        public int Interpret(Dictionary<string, Expression> variables)
        {
            return _number;
        }

        
    }
}

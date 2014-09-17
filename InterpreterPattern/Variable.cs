using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Variable : Expression
    {
        private String name;
        public Variable(String name) { this.name = name; }
        public int Interpret(Dictionary<String, Expression> variables)
        {
            if (null == variables[name]) return 0; //Either return new Number(0).
            return variables[name].Interpret(variables);
        }
    }
}

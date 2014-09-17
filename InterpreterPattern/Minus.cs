using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Minus : Expression
    {
        Expression leftOperand;
        Expression rightOperand;
        public Minus(Expression left, Expression right)
        {
            leftOperand = left;
            rightOperand = right;
        }

        public int Interpret(Dictionary<String, Expression> variables)
        {
            return leftOperand.Interpret(variables) - rightOperand.Interpret(variables);
        }
 
    }
}

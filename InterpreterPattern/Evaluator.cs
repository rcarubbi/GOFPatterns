using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Evaluator : Expression
    {
        private Expression syntaxTree;

        public Evaluator(String expression)
        {
            Stack<Expression> expressionStack = new Stack<Expression>();
            foreach (String token in expression.Split(new string[] {" "}, StringSplitOptions.None))
            {
                if  (token.Equals("+")) {
                    Expression subExpression = new Plus(expressionStack.Pop(), expressionStack.Pop());
                    expressionStack.Push( subExpression );
                }
                else if (token.Equals("-"))
                {
                    // it's necessary remove first the right operand from the stack
                    Expression right = expressionStack.Pop();
                    // ..and after the left one
                    Expression left = expressionStack.Pop();
                    Expression subExpression = new Minus(left, right);
                    expressionStack.Push(subExpression);
                }
                else
                    expressionStack.Push(new Variable(token));
            }
            syntaxTree = expressionStack.Pop();
        }
 

        public int Interpret(Dictionary<string, Expression> context)
        {
            return syntaxTree.Interpret(context);
        }
    }
}

using System;
using System.Collections.Generic;
namespace InterpreterPattern
{
    interface Expression
    {
        int Interpret(Dictionary<String, Expression> variables);
    }
}

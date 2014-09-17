using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a expressão com 3 variaveis (w, x e z)");
            String expression = Console.ReadLine();
            Evaluator sentence = new Evaluator(expression);
            Dictionary<String,Expression> variables = new Dictionary<String,Expression>();
            Console.WriteLine("w=");
            variables.Add("w", new Number(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("x=");
            variables.Add("x", new Number(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("z=");
            variables.Add("z", new Number(Convert.ToInt32(Console.ReadLine())));
            int result = sentence.Interpret(variables);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

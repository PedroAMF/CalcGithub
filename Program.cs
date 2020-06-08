using System;

namespace CalcGithub {
    class Program {
        static void Main (string[] args) {
            int num1;
            int num2;
            int soma;
            Console.WriteLine ("Digite o primeiro numero:");
            num1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o segundo numero:");
            num2 = int.Parse (Console.ReadLine ());
            soma = num1 + num2;

            Console.WriteLine (soma);
        }
    }
}
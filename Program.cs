using System;

namespace CalcGithub {
    class Program {
        static void Main (string[] args) {

            float num1;
            float num2;
            float resultado;
            int choiseUser;

            Console.WriteLine ("Bem vindo a calculadora simples");
            Console.WriteLine ("1 - Para somar(+)");
            Console.WriteLine ("2 - Para diminuir(-)");
            Console.WriteLine ("3 - Para multiplicar(*)");
            Console.WriteLine ("4 - Para dividir(/)");

            choiseUser = int.Parse (Console.ReadLine ());

            switch (choiseUser) {
                case 1:

                    Console.WriteLine ("Digite o primeiro numero:");
                    num1 = float.Parse (Console.ReadLine ());
                    Console.WriteLine ("Digite o segundo numero:");
                    num2 = float.Parse (Console.ReadLine ());
                    resultado = num1 + num2;

                    Console.WriteLine (resultado);
                    break;
                case 2:

                    Console.WriteLine ("Digite o primeiro numero:");
                    num1 = float.Parse (Console.ReadLine ());
                    Console.WriteLine ("Digite o segundo numero:");
                    num2 = float.Parse (Console.ReadLine ());
                    resultado = num1 - num2;
                    Console.WriteLine (resultado);
                    break;
                case 3:

                    Console.WriteLine ("Digite o primeiro numero:");
                    num1 = float.Parse (Console.ReadLine ());
                    Console.WriteLine ("Digite o segundo numero:");
                    num2 = float.Parse (Console.ReadLine ());
                    resultado = num1 * num2;
                    Console.WriteLine (resultado);
                    break;
                case 4:

                    Console.WriteLine ("Digite o primeiro numero:");
                    num1 = float.Parse (Console.ReadLine ());
                    Console.WriteLine ("Digite o segundo numero:");
                    num2 = float.Parse (Console.ReadLine ());
                    resultado = num1 / num2;
                    Console.WriteLine (resultado);
                    break;
                default:
                    throw new InvalidOperationException ("Opção não encontrada");

            }

        }

    }
}
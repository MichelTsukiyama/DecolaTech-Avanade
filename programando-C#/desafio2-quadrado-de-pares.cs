using System;

class DIO
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                int b = i * i;          //escreva o seu código nos espaços em branco
                Console.WriteLine(i + "^2 = " + b);
            }
        }
    }
}

//A Lógica principal aqui é usar o operador %(módulo) para verificar se um número é par ou não. Todo número par tem resto 0, quando dividido por 2.
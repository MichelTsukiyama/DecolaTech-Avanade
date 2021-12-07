//Todo número com raiz quadrada exata e inteira possui um número ímpar de divisores.

using System;

class DIO
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            int qntEsferas = int.Parse(Console.ReadLine());

            Console.WriteLine(qntEsferas - Math.Floor(Math.Sqrt(qntEsferas)));
        }
        //escreva aqui o seu código
    }
}


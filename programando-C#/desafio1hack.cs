//Todo n�mero com raiz quadrada exata e inteira possui um n�mero �mpar de divisores.

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
        //escreva aqui o seu c�digo
    }
}


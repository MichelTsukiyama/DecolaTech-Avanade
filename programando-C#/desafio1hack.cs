//Tentei usar a forma abaixo, mas também não deu certo
//Aqui eu usei um código para verificar todas as 109 possibilidades, o interessante é que somente números que possuem raiz quadrada exata possuem uma quantidade ímpar de divisores.

using System;

class DIO
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            int qntEsferas = int.Parse(Console.ReadLine());
            int ignorarEsferas = 0;

            if (qntEsferas < 4)
            {
                ignorarEsferas = 1;
            }
            else if (qntEsferas < 9)
            {
                ignorarEsferas = 2;
            }
            else if (qntEsferas < 16)
            {
                ignorarEsferas = 3;
            }
            else if (qntEsferas < 25)
            {
                ignorarEsferas = 4;
            }
            else if (qntEsferas < 36)
            {
                ignorarEsferas = 5;
            }
            else if (qntEsferas < 49)
            {
                ignorarEsferas = 6;
            }
            else if (qntEsferas < 64)
            {
                ignorarEsferas = 7;
            }
            else if (qntEsferas < 81)
            {
                ignorarEsferas = 8;
            }
            else if (qntEsferas < 100)
            {
                ignorarEsferas = 9;
            }
            else if (qntEsferas < 110)
            {
                ignorarEsferas = 10;
            }

            Console.WriteLine(qntEsferas - ignorarEsferas);
        }
        //escreva aqui o seu código
    }
}
using System;

class DIO
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 7; j > 4; j--)    //escreva seu código nos espaços em branco
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}

//Neste desafio você precisa fazer um laço dentro de outro
//Usei como lógica ele imprimir somente os valores ímpares de I, com o operador de módulo (um número é ímpar se o resto da divisão dele por 2 for diferente dee 0)
//Para imprimir os valores de J é só controlar o laço para que fique entre 7 e 5
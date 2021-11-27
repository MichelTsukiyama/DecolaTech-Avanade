using System;

class DIO
{
    static void Main(string[] args)
    {
        double c, S = 0;
        for (float i = 1; i <= 100; i++)
        {
            c = 1 / i;  //coloque a sua lógica nos espaços em branco
            S += c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);
    }
}

//Neste desafio basta somar os valores 1/n + 1/(n+1)... até chegar a 1/100
//lembrando que:
//    1/1 = 1
//    1/2 = 0.5
//    1/3 = 0.3333...
//    ...
//    1/100 = 0.01
//Somando: 1 + 0.5 + 0.3333.... + 0.01
//dica: no laço for, use o tipo float, assim poderá usar o controle do laço para fazer as divisões retornando números com ponto flutuante
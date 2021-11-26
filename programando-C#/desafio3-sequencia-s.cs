using System;

class DIO
{
    static void Main(string[] args)
    {
        double c, S = 0;
        for (float i = 1; i <= 100; i++)
        {
            c = 1 / i;  //coloque a sua l�gica nos espa�os em branco
            S += c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);
    }
}

//Neste desafio basta somar os valores 1/n + 1/(n+1)... at� chegar a 1/100
//lembrando que:
//    1/1 = 1
//    1/2 = 0.5
//    1/3 = 0.3333...
//    ...
//    1/100 = 0.01
//Somando: 1 + 0.5 + 0.3333.... + 0.01
//dica: no la�o for, use o tipo float, assim poder� usar o controle do la�o para fazer as divis�es retornando n�meros com ponto flutuante
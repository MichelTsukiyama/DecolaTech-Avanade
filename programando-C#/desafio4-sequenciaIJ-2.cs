using System;

class DIO
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 7; j > 4; j--)    //escreva seu c�digo nos espa�os em branco
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}

//Neste desafio voc� precisa fazer um la�o dentro de outro
//Usei como l�gica ele imprimir somente os valores �mpares de I, com o operador de m�dulo (um n�mero � �mpar se o resto da divis�o dele por 2 for diferente dee 0)
//Para imprimir os valores de J � s� controlar o la�o para que fique entre 7 e 5
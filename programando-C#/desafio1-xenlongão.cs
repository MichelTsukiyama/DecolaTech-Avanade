//Por enquanto s� est� passando no teste 1
//Pode entregar o desafio se passar no primeiro teste, ele ser� aceito.
//N�o h� como saber se o 2� teste n�o passa por bug ou tempo limite.

//Neste desafio a l�gica seria receber um valor inicial, esse valor vai determinar a quantidade de testes.
//Utilize um la�o de repeti��o para que o c�digo ocorra de acordo com a quantidade de testes
//Dentro deste la�o rfa�a a verifica��o esfera por esfera, da quantidade de vezes que ela pode ser dividida, se 
using System;

class DIO
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            int qntEsferas = int.Parse(Console.ReadLine());
            int qntDivisoes = 0;
            int ignorarEsferas = 1;
            for (int j = 2; j <= qntEsferas; j++)
            {
                qntDivisoes = 0;
                for (int k = 1; k <= j; k++)
                {
                    if (j % k == 0)
                    {
                        qntDivisoes++;
                    }
                }
                if (qntDivisoes % 2 != 0)
                {
                    ignorarEsferas++;
                }
            }
            Console.WriteLine(qntEsferas - ignorarEsferas);
        }
        //escreva aqui o seu c�digo
    }
}
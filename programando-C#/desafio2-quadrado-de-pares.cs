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
                int b = i * i;          //escreva o seu c�digo nos espa�os em branco
                Console.WriteLine(i + "^2 = " + b);
            }
        }
    }
}

//A L�gica principal aqui � usar o operador %(m�dulo) para verificar se um n�mero � par ou n�o. Todo n�mero par tem resto 0, quando dividido por 2.
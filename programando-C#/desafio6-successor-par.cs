using System;

class DIO
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine(x + 2);      //escreva aqui o seu c�digo
        }
        else
        {
            Console.WriteLine(x + 1);
        }
    }
}

//Aqui usei a l�gica de verificar se um n�mero � par (um n�mero � par quando o resto da sua divis�o por 2 � 0)
//Se o n�mero for par, o pr�ximo n�mero par vai ser ele mesmo + 2;
//Se o n�mero for �mpar, o pr�ximo n�mero par vai ser ele mesmo +1;

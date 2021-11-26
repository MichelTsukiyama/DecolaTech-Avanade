using System;

class DIO
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine(x + 2);      //escreva aqui o seu código
        }
        else
        {
            Console.WriteLine(x + 1);
        }
    }
}

//Aqui usei a lógica de verificar se um número é par (um número é par quando o resto da sua divisão por 2 é 0)
//Se o número for par, o próximo número par vai ser ele mesmo + 2;
//Se o número for ímpar, o próximo número par vai ser ele mesmo +1;

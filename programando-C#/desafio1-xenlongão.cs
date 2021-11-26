//Por enquanto só está passando no teste 1

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
                for (int k = 1; k <= j; k++)
                {
                    if (qntEsferas % k == 0)
                    {
                        qntDivisoes++;
                    }
                }
            }
            if (qntDivisoes % 2 != 0)
            {
                ignorarEsferas++;
            }
            Console.WriteLine(qntEsferas - ignorarEsferas);
            //Console.WriteLine("x="+x+" qntEsferas="+qntEsferas+" ignorarEsferas=" + ignorarEsferas+ " qntDivisoes="+qntDivisoes);
        }
        //escreva aqui o seu código
    }
}
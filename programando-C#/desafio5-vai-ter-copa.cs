using System;

class DIO
{
    static void Main(string[] args)
    {
        string str;
        while ((str = Console.ReadLine()) != null)
        {
            int x = int.Parse(str);
            if (x > 0)
            {
                Console.WriteLine("vai ter duas!");
            }
            else
            {
                Console.WriteLine("vai ter copa!");
            }
        }
    }
}

//Neste desafio basta utilizar uma condi��o, se o valor reecebido for maior que 0 retorne "vai ter duas!", caso contr�rio retorne "vai ter copa!"
namespace Classes.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            reesultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        {
            Dividir(10, 30, out int resultado, out int resto);
            System.Console.WriteLine($"{0} {1}", resultado, resto);
        }
    }
}
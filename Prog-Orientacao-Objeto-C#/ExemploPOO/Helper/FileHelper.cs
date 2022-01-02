namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDirectory(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListFiles(string caminho)
        {
            var returnFiles = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in returnFiles)
            {
                System.Console.WriteLine(retorno);
            }
        }
    }
}
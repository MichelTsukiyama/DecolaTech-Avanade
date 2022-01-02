using System;
using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\DCM";

            FileHelper helper = new FileHelper();
            // helper.ListarDirectory(caminho);
            helper.ListFiles(caminho);

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob"; 
            // p1.Nota = 20;
            // p1.Apresentar();

            
            // Retangulo r = new Retangulo();

            // r.DefinirMedidas(30,30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");


            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}

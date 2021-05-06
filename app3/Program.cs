using System;
using System.IO;

namespace app03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string currentDirectory = Directory.GetCurrentDirectory();

            var app = new MyApp(currentDirectory);

            app.CarregarLista();
            app.ImprimirLista();

            Pessoa ricardo = app.BuscarPessoa("Ricardo");
            DateTime dataNascimento = DateTime.Parse(ricardo.DataNascimento);
            dataNascimento = dataNascimento.AddYears(-1);
            ricardo.DataNascimento = dataNascimento.ToString("dd/MM/yyyy");

            app.SalvarLista();
            app.ImprimirLista();
        }
    }
}

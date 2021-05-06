using System;

namespace app02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Writeline();
            Console.Writeline("## app 02 ##");

            //pasta local do projeto
            string caminhoDaPastaLocal = System.IO.Directory.GetCurrentDirectory();
            Console.Writeline();
            Console.Writeline("caminhoDaPastaLocal: {0}", caminhoDaPastaLocal);

            //Combino o caminho da pasta local com o nome do arquivo
            string caminhoDoArquivo = System.IO.Path.Combine(caminhoDaPastaLocal, $"pessoas.txt");
            Console.Writeline();
            Console.Writeline("caminhoDoArquivo: {0}", caminhoDoArquivo);

            //Leio o conteúdo do arquivo
            string conteudoDoArquivo = System.IO.File.ReadAllText(caminhoDoArquivo);
            Console.Writeline();
            Console.Writeline("conteudoDoArquivo: {0}", conteudoDoArquivo);


            string[] nomes = conteudoDoArquivo.Split(';');

            Console.Writeline();
            Console.Writeline("Array de Tamanho: {0}", nomes.Lenght);

            Console.Writeline();
            Console.Writeline("foreach");
            foreach (var nome in nomes)
            {
                Console.Writeline(nome);
            }

            Console.Writeline();
            Console.Writeline("for");
            for (int i = 0; i < nomes.Lenght; i++)
            {
                string nome = nomes[i]
                Console.Writeline(nomes[i]);
            }

            Console.Writeline();
            Console.Writeline("while");
            int index = 0;
            while (index < nomes.Lenght)
            {
                string nome = nomes[index];
                Console.Writeline(nome);
                index++;
            }
        }
    }
}
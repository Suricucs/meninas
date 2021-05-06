using System;
using System.Linq;

namespace app03
{
    public class MyApp
    {
        private Pessoa[] _pessoas;
        private PessoaRepository _repository;

        public MyApp(string directory) {
            _repository = new PessoaRepository(directory);
        }

        public void CarregarLista()
        {
            Console.WriteLine();
            Console.WriteLine("## Carregar Lista ##");
            _pessoas = _repository.Read();
        }

        public void SalvarLista()
        {
            Console.WriteLine();
            Console.WriteLine("## Salvar Lista ##");
            _repository.Save(_pessoas);
        }

        public void ImprimirLista()
        {
            Console.WriteLine();
            Console.WriteLine("## Lista de Pessoas ##");
            foreach (var pessoa in _pessoas)
            {
                Console.WriteLine("Nome: {0}; DataNascimento: {1}; Email: {2}; Telefone: {3}",
                    pessoa.NomeCompleto,
                    pessoa.DataNascimento,
                    pessoa.Email,
                    pessoa.Telefone);
            }
        }

        public Pessoa BuscarPessoa(string nome)
        {
            Console.WriteLine();
            Console.WriteLine("## Burcar Pessoas ##");
            foreach (var pessoa in _pessoas)
            {
                if (pessoa.NomeCompleto.StartsWith(nome))
                {
                    return pessoa;
                }
            }
            return null;
        }
    }
}
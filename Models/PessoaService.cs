using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Models
{
    public class PessoaService
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void AdicionarPessoa(string nome, int idade)
        {
            Pessoa novaPessoa = new Pessoa(nome, idade);

            pessoas.Add(novaPessoa);
            Console.WriteLine("Uma pessoa foi adicionada na lista");
        }
        public void ListarPessoa()
        {
            Console.WriteLine("Lista de Pessoas adicionadas");
            Console.WriteLine();

            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada na lista.");
            }

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

        }

        public void AtualizarPessoa(int id, string novoNome, int novaIdade)
        {
            bool pessoaEncontrada = false;

            foreach (var pessoa in pessoas)
            {
                if (pessoa.Id == id)
                {
                    pessoa.Nome = novoNome;
                    pessoa.Idade = novaIdade;
                    pessoaEncontrada = true;
                    break;
                }
            }
            if (pessoaEncontrada)
            {
                Console.WriteLine("Usuário atualizado com sucesso!");

            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }
        }
        public void RemoverPessoa(int id)
        {
            Console.WriteLine("-- Lista de pessoas --");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("Digite o ID do usuário que voce quer remover:");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int parsedId))
            {
                Console.WriteLine("ID inválido");
                return;
            }

            bool pessoaEncontrada = false;

            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Id == parsedId)
                {
                    pessoas.RemoveAt(i);
                    pessoaEncontrada = true;
                    break;
                }
            }
            if (pessoaEncontrada)
            {
                Console.WriteLine("Pessoa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Pessoa não cadastrada na lista");
            }
        }
    }
}
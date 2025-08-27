using System;
using ProjetoCadastro.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

PessoaService pessoaService = new PessoaService();
bool menu = true;


while (menu)
{
    Console.WriteLine("------- MENU --------");
    Console.WriteLine("1 - Adicionar Pessoa");
    Console.WriteLine("2 - Listar Pessoa");
    Console.WriteLine("3 - Atualizar Pessoa");
    Console.WriteLine("4 - Remover Pessoa");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("Digite a função desejada");
    string? taskFunction = Console.ReadLine();


    switch (taskFunction)
    {
        case "1":
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);
            pessoaService.AdicionarPessoa(nome, idade);
            break;
        case "2":
            pessoaService.ListarPessoa();
            break;
        case "3":
            Console.WriteLine("Digite o ID da pessoa para atualizar: ");
            int idAtualizar = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o novo nome: ");
            string novoNome = Console.ReadLine()!;
            Console.WriteLine("Digite a nova idade: ");
            int novaIdade = int.Parse(Console.ReadLine()!);
            pessoaService.AtualizarPessoa(idAtualizar, novoNome, novaIdade);
            break;
        case "4":
            pessoaService.RemoverPessoa(0);
            break;
        case "0":
            menu = false;
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }       


}







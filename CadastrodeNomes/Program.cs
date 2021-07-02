using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastrodeNomes
{
    class Program
    {
        List<string> clientes = new List<string>();
        public static void Main(string[] args)
        {
            Console.WriteLine("------------Sistema de cadastro de clientes----------");
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("1-Incluir Cliente");
            Console.WriteLine("2-Alterar cadastro de cliente");
            Console.WriteLine("3-Exibir lista de clientes");
            Console.WriteLine("4-Excluir cadastro de cliente");
            Console.WriteLine("5- Sair");

            var opcoes = Console.ReadLine();
           
            switch (opcoes)
            {
                case "1":

                    Console.WriteLine("Qual o nome do cliente? ");
                    Console.WriteLine("Nome: ");

                    clientes.Add(Console.ReadLine());



                   

                    break;

                case "2":
                    Console.WriteLine("-------Alteração de cadastro------");
                    Console.WriteLine("Qual o nome do cliente ?");

                

                    var nomeantigo = Console.ReadLine();

                    var clienteachado = clientes.FindIndex(c => c.Equals(nomeantigo));

                    if (clienteachado > -1)
                    {
                        Console.WriteLine("Escreva nome do cliente novo");
                        clientes[clienteachado] = Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("Não foi achado cliente com esse nome. ");
                    }
                                          


                    break;

                case "3":

                    Console.WriteLine("-----------------Lista de clientes--------------");
                    foreach (string cliente in clientes)
                    {
                        
                        Console.WriteLine(cliente);
                    }

                    break;

                case "4":
                    Console.WriteLine("-----------------Remover cliente da lista-----------------");

                    Console.WriteLine("Qual o nome do cliente a ser removido? ");

                    var nomedeletar = Console.ReadLine();
                    var procuracliente = clientes.FindIndex(c => c.Equals(nomedeletar));

                    if (procuracliente > -1)
                    {

                        clientes.RemoveAt(procuracliente);

                        Console.WriteLine("Cliente removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Não foi achado cliente com esse nome. ");
                    }

                    break;

                case "5":
                    Environment.Exit(0);

                    break;
            }

            



    }

        public static string Opcaousuario()
        {

        }







    }
}

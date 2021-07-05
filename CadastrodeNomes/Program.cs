using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastrodeNomes
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            string opcoes = Opcaousuario();

            while (opcoes != "5")
            {
                switch (opcoes)
                {
                    case "1":

                        Console.WriteLine("Qual o nome do cliente? ");
                        Console.WriteLine("Nome: ");

                        var nome = Console.ReadLine();

                        var verificarcliente = clientes.FindIndex(c => c.Equals(nome));
                        
                        if (verificarcliente > -1)
                        {
                            Console.WriteLine("Já existe cliente com esse nome! ");
                            Console.WriteLine("                                 ");
                        }
                       
                        else if (string.IsNullOrWhiteSpace(nome))
                        {
                            Console.WriteLine("Nome invalido!Não deixar espaços vazio!");
                            Console.WriteLine("                                 ");
                        }
                        else
                        {
                            Console.WriteLine("Cliente adicionado com sucesso! ");
                            Console.WriteLine("                                 ");
                            clientes.Add(nome);
                        }


                        break;

                    case "2":
                        Console.WriteLine("-------Alteração de cadastro------");
                        Console.WriteLine("                                 ");
                        Console.WriteLine("Qual o nome do cliente a ser alterado ?");
                        Console.WriteLine("Nome: ");
                        Console.WriteLine("                                 ");


                        var nomeantigo = Console.ReadLine();

                        var clienteachado = clientes.FindIndex(c => c.Equals(nomeantigo));

                        if (clienteachado > -1)
                        {
                            Console.WriteLine("Escreva nome do cliente novo");
                            Console.WriteLine("Nome: ");
                            clientes[clienteachado] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Não foi achado cliente com esse nome. ");
                            Console.WriteLine("                                 ");
                        }



                        break;

                    case "3":

                        Console.WriteLine("-----------------Lista de clientes--------------");
                        Console.WriteLine("                                 ");


                        foreach (string cliente in clientes)
                        {

                            Console.WriteLine(cliente);
                        }

                        break;

                    case "4":
                        Console.WriteLine("-----------------Remover cliente da lista-----------------");
                        Console.WriteLine("                                 ");

                        Console.WriteLine("Qual o nome do cliente a ser removido? ");
                        Console.WriteLine("Nome: ");

                        var nomedeletar = Console.ReadLine();
                        var procuracliente = clientes.FindIndex(c => c.Equals(nomedeletar));

                        if (procuracliente > -1)
                        {

                            clientes.RemoveAt(procuracliente);

                            Console.WriteLine("Cliente removido com sucesso");
                            Console.WriteLine("                                 ");
                        }
                        else
                        {
                            Console.WriteLine("Não foi achado cliente com esse nome. ");
                            Console.WriteLine("                                 ");
                        }

                        break;

                    case "5":
                        Environment.Exit(0);

                        break;
                }

                opcoes = Opcaousuario();

            }



    }

        public static string Opcaousuario()
        {
            Console.WriteLine("------------Sistema de cadastro de clientes----------");
            Console.WriteLine("                                 ");
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("1-Incluir Cliente");
            Console.WriteLine("2-Alterar cadastro de cliente");
            Console.WriteLine("3-Exibir lista de clientes");
            Console.WriteLine("4-Excluir cadastro de cliente");
            Console.WriteLine("5-Sair");

            var opcoes = Console.ReadLine();

            return opcoes;
        }







    }
}

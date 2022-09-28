using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda1
{
    internal class Program
    {
        static int MENU()
        {
           
            Console.WriteLine("\n\nAgenda Consultório\n");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("1 - Cadastrar paciente");
            Console.WriteLine("2 - Exibir pacientes");
            Console.WriteLine("3 - Busca");
            Console.WriteLine("4 - Editar");
            Console.WriteLine("5 - Excluir");

            Console.WriteLine("\nEntre com uma opcao: ");

            return int.Parse(Console.ReadLine()); 

        }
        static void Main(string[] args)
        {
            // Paciente[] pac = new Paciente[100];

            string[] nome = new string[100]; 
            string[] telefone = new string[100];    


            int opcao, qtd = 0, i, posicao; 

            do
            {
                opcao = MENU ();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nObrigada por utilizar o sistema");
                        break;

                    case 1:
                        Console.WriteLine("\nCadastro de Paciente\n");

                        if (qtd >= 100)
                        {
                            Console.WriteLine("Entre em contato com administrador!");
                        }
                        else
                        {
                            Console.WriteLine("\nEntre com o nome do paciente: ");
                            nome[qtd] = Console.ReadLine();

                            Console.WriteLine("Entre com o numero de telefone: ");
                            telefone[qtd] = Console.ReadLine();

                            qtd++;

                            Console.WriteLine("\nPACIENTE CADASTRADO COM SUCESSO!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nPacientes Cadastrados\n");

                        for (i = 0; i < qtd; i++)
                        {
                            Console.WriteLine("====Paciente {0}====\n", i + 1);
                            Console.WriteLine("Nome: " + nome[i]);
                            Console.WriteLine("Telefone:" + telefone[i]);



                        }
                       
                        break;
                        

                    

                    case 3: Console.WriteLine("\nBusca de Paciente\n");

                        Console.WriteLine("Digite o nome a ser buscado: "); 
                        string nomeBuscado = Console.ReadLine().ToLower();

                        bool validacao = false;

                        for (i = 0; i < qtd; i++)
                        {
                            if (nome[i].ToLower().Contains(nomeBuscado))

                            Console.WriteLine("\nNome: " + nome[i]);
                            Console.WriteLine("Telefone: " + telefone[i]);

                            validacao = true;

                        }

                        if (!validacao)
                            Console.WriteLine("\nNao existe esse paciente");
                        else
                            Console.WriteLine("\nBUSCA ENCERRADA!");

                        break;

                    case 4: Console.WriteLine("\nEditar cadastro\n");

                        Console.WriteLine("Digite o nome que deseja editar: \n"); 
                        string nomeEditar = Console.ReadLine().ToLower();


                        validacao = false;
                        string nomeEditado;

                        for (i = 0; i < qtd; i++)
                        {
                            if (nome[i].ToLower().Contains(nomeEditar))
                            {
                                Console.WriteLine("=====Paciente {0}=====", i + 1); 
                                Console.WriteLine("Nome: " + nome[i]);
                                Console.WriteLine("Telefone: " + telefone[i]); 
                                validacao = true;
                            }

                            if (validacao == true)
                            {
                                Console.WriteLine("Entre com o numero da posicao do nome a ser editado");
                                posicao = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nPaciente {0}\n\n", posicao);

                                Console.WriteLine("Nome atual: {0} \nDigite o novo nome ou aperte enter para sair!", nome[i]); 
                                nomeEditado = Console.ReadLine().ToLower();

                                nome[i] = nomeEditado.Length == 0 ? nome[i] : nomeEditado;
                            }
                            if (!validacao)
                                Console.WriteLine("Nenhum paciente com o nome {0} foi encontrado", nomeEditar);
                            else
                                Console.WriteLine("\nPACIENTE EDITADO!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nExcluir Paciente\n\n");

                        Console.WriteLine("Digite o nome que deseja editar: \n");
                        string nomeExcluir = Console.ReadLine().ToLower();



                        validacao = false;


                        for (i = 0; i < qtd; i++)
                        {
                            if (nome[i].ToLower().Contains(nomeExcluir))
                            {
                                Console.WriteLine("\n=====Paciente {0}=====", i + 1);
                                Console.WriteLine("Nome: " + nome[i]);
                                Console.WriteLine("Telefone: " + telefone[i]);
                                validacao = true;
                            }
                        }

                        for (i = 0; i < qtd; i++)
                        {
                            if (validacao == true)
                            {
                                Console.WriteLine("Digite o numero do paciente a ser excluido");
                                posicao = int.Parse(Console.ReadLine().ToLower());

                                nome[posicao-1] = nome[qtd-1];
                                telefone[posicao-1] = telefone[qtd-1];
                                qtd--;

                            }

                        }
                        if (validacao == false)
                        
                            Console.WriteLine("Nenhum paciente com o nome {0} foi encontrado", nomeExcluir);
                         else
                            Console.WriteLine("\nPACIENTE EXCLUIDO");

                        break;

                        
                        default:

                        Console.WriteLine("Opcao Invalida!");
                        Console.ReadKey();

                        break;

                }
             
            } while (opcao != 0);   

            


        }

    }
}

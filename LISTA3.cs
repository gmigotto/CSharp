using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    internal class Program
    {   
        static void EX1()
        {
            Random num_qualquer = new Random();
            double maior = int.MinValue, menor = int.MaxValue, num, soma=0;

            for (int i= 0; i < 213; i++)
            {
                num = (double) num_qualquer.Next(0,1000);

                Console.WriteLine("{0} Numero: {1}", i, num);

                if (num > maior)
                {
                    maior = num; 
                }
                if (num < menor)
                {
                    menor = num;
                }

                soma = num + 1;

            }
            double aritmetica;

            aritmetica = soma / 213; 

            Console.WriteLine ("\nMaior numero:{0}\nMenor numero: {1}\nMedia Aritmetica: {2}", maior, menor, aritmetica);
            Console.ReadKey(); 
        }

        static void Ex2()
        {
            Console.WriteLine("ENTRE COM UM CONJUNTO DE NUMEROS: \n " +
                                     "Digite 0 para sair.\n");
            Console.WriteLine("");
            int entrada, soma=0, i=0; 
            do 
            {
                
                Console.WriteLine("\nNumero: ");
                entrada = int.Parse(Console.ReadLine());

                soma = soma + entrada;
                i = i + 1;


            } while (entrada != 0);

            float aritmetica;

            aritmetica = (float) soma / (i -1);

            Console.WriteLine("Media Aritmetica: {0}", aritmetica);

        }

        static void Ex3()
        { int X, Z;
            Console.WriteLine("Entre com um intervalo de numeros!\n ");
            Console.WriteLine("De:"); 
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Até:");
            Z = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n****Numeros divididos por 7 com resto 3****\n");

            for (int i = X; i < Z; i++)
            {
                if ( i % 7 == 3)
                {
                    Console.WriteLine("{0}", i); 
                }
            }
                
        }

        static void Ex4()
        {
            Random qualquernum = new Random();

            int num, soma_par = 0, soma_impar = 0;

            Console.WriteLine("\nSoma dos numeros impares e pares\n ");

            for (int i = 0; i < 93; i++)
            {
                num = qualquernum.Next(0,100);

                if (num % 2 == 0)
                {
                    soma_par = soma_par + num; 
                }

                if (num % 2 != 0)
                {
                    soma_impar = soma_impar + num; 
                }
            }

            Console.WriteLine("\n\nSoma Par: {0}\nSoma Impar:{1}", soma_par, soma_impar); 
        }

        static void Ex5()
        {
            int P;

            Console.WriteLine("Atribua um valor inteiro a variavel P: \n");
            P = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nNumeros impares divisiveis por 3, mas não por 6!\n");

            for ( int i = 0; i < P * P ; i++)
            {
                if ((i % 2 != 0) && (i % 3 == 0) && (i % 6 != 0))
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }

        static void Ex6()
        {
            int linha;
            char caracter; 

            Console.Write("Entre com o numero de linhas: ");
            linha = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com um caractere: ");
            caracter = char.Parse(Console.ReadLine); 

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(caracter); 
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine("*****Lista 3*****"); 
            Console.WriteLine("1 - Ex1"); 
            Console.WriteLine("2 - Ex2"); 
            Console.WriteLine("3 - Ex3"); 
            Console.WriteLine("4 - Ex4"); 
            Console.WriteLine("5 - Ex5"); 
            Console.WriteLine("6 - Ex6");

            Console.WriteLine("Entre com uma opcao: ");

            return int.Parse(Console.ReadLine()); 
           
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Sessao encerrada!");
                        Console.ReadKey();
                        break;

                    case 1:
                        EX1();

                        Console.ReadKey();

                        break;
                    
                    case 2: Ex2();

                        Console.ReadKey();

                        break; 
                    
                    case 3: Ex3();

                        Console.ReadKey();

                        break;
                    
                    case 4: Ex4();

                        Console.ReadKey();

                        break;
                    
                    case 5: Ex5();

                        Console.ReadKey();

                        break;    
                    
                    case 6: Ex6();

                        Console.ReadKey();

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

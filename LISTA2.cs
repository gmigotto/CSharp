using System;
using System.Net;
using System.Text.RegularExpressions;

namespace LISTA2
{
    internal class Program
    { static void ExA()
        {
            int num1, num2, num3;

            Console.WriteLine("Entre com o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());

            int n;

             if (num2 < num1)
             {
                n = num1;
                num1= num2;
                num2 = n; 
             } 
             if (num3 < num1)
            {
                n = num1;
                num1 = num3; 
                num3 = n;
            }
             if (num3 < num2)
            {
                n = num2;
                num2 = num3;
                num3 = n;
            }
             Console.WriteLine("Ordem crescente: {0} {1} {2}", num1, num2, num3);


            Console.ReadKey();

        }

        //Math.Pow (3, 2)
        static void ExB()
        {
            float r;

            Console.WriteLine("Entre com o angulo radiano: ");
            r = float.Parse(Console.ReadLine());

            double G;

            G = (r * 180) / Math.PI;

            Console.WriteLine("Angulo em graus:{0}", G);

            Console.ReadKey();

        }

        static void ExC()
        {
            float a, b;

            Console.WriteLine("Entre com o cateto A: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o cateto B: ");
            b = float.Parse(Console.ReadLine());

            double hipotenusa;
            hipotenusa = (Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("Hipotenusa: {0}", hipotenusa);

            Console.ReadKey();

        }

        static void ExD()
        {
            int num;
            double raiz;

            Console.WriteLine("Entre com um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0 && num % 2 == 0)
            {
                raiz = (float)Math.Sqrt(num);

                Console.WriteLine("Raiz:{0}", raiz);
            } else
            {
                Console.WriteLine("Numero invalido");
            }
        }
        static void ExE()
        {
            int num1, num2;

            Console.WriteLine("Entre com o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os numeros são iguais!\n");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("Maior numero:{0}", num1);
                }
                else
                {
                    Console.WriteLine("Maior numero:{0}", num2);
                }
            }


        }

        static void ExF()
        {
            int opcao;

            Console.WriteLine("Digite um numero de 1 a 7: ");
            opcao = int.Parse(Console.ReadLine());



            switch (opcao)
            {
                case 0: Console.WriteLine("Numero invalido\n");
                    Console.ReadKey();
                    break;

                case 1: Console.WriteLine("Domingo\n");
                    Console.ReadKey();
                    break;

                case 2: Console.WriteLine("Segunda\n");
                    Console.ReadKey();
                    break;

                case 3: Console.WriteLine("Terca\n");
                    Console.ReadKey();
                    break;

                case 4: Console.WriteLine("Quarta\n");
                    Console.ReadKey();
                    break;

                case 5: Console.WriteLine("Quinta\n");
                    Console.ReadKey();
                    break;

                case 6: Console.WriteLine("Sexta\n");
                    Console.ReadKey();
                    break;

                case 7: Console.WriteLine("Sabado\n");
                    Console.ReadKey();
                    break;

                default: Console.WriteLine("Opcao Invalida!");
                    Console.ReadKey();
                    break;


            }


        }

        static void ExG()
        {
            int num1, num2;

            Console.WriteLine("Entre com o primeiro numero\n");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero\n");
            num2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int operacao;

            Console.WriteLine("1 - Adicao");
            Console.WriteLine("2 - Multipicacao");
            Console.WriteLine("3 - Subtracao");
            Console.WriteLine("4 - Divisao \n");
            Console.WriteLine("Escolha uma Operação: \n");
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 0: Console.WriteLine("Opcao invalida");
                    break;
                case 1:
                    Console.WriteLine("Resultado: {0}", num1 + num2);
                    break;
                case 2: Console.WriteLine("Resultado: {0}", num1 * num2);
                    break;
                case 3: Console.WriteLine("Resultado: {0}", num1 - num2);
                    break;
                case 4: Console.WriteLine("Resultado: {0}", num1 / num2);
                    break;

                default: Console.WriteLine("Opcao invalida"); break;
            }

        }
        static void ExI()
        {
            double km, l;

            Console.WriteLine("Entre com os quilometros percorridos: "); 
            km = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com os litros de gasolina: "); 
            l = double.Parse(Console.ReadLine());

            double consumo;

            consumo = km / l;

            if (consumo < 8)
                Console.WriteLine("Venda seu carro ou compre um posto!");
            if (consumo >= 8 && consumo <= 14)
                Console.WriteLine("Economico!");
            if (consumo > 14)
                Console.WriteLine("Super economico!"); 

        }

        static void ExJ()
        {
            int num1, num2, num3;

            Console.WriteLine("Entre com o primeiro numero: "); 
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o segundo numero: "); 
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o terceiro numero: "); 
            num3 = int.Parse(Console.ReadLine());

            double ponderada, harmonica, aritmetica;

            ponderada =  (num1 + (2 * num2) + num3) / 6; 

            harmonica =  ( 1/ ((1/(double)num1)+(1/(double)num2)+(1/(double)num3)));

            aritmetica = (num1 + num2 + num3) / 3;

            Console.WriteLine("Media Ponderada:{0}\nMedia Harmonica:{1}\nMedia Aritmetica:{2}\n", ponderada, harmonica, aritmetica); 

        }
        static void ExH()
        {
            int num; 

            Console.WriteLine("Entre com um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("O numero e divisivel por 3"); 
            }
            if (num % 5 == 0)
            {
                Console.WriteLine("O numero e divisivel por 5");
            }
        }

        static void ExK()
        {
            double venda; 

            Console.WriteLine("Entre com o valor da venda: ");
            venda = double.Parse(Console.ReadLine());

            double comissao; 

            if (venda >= 100000)
            {
                comissao = (venda * 0.16) + 700;
                Console.WriteLine("Comissão do vendedor: {0}", comissao);
            }

            if (venda <100000 && venda >= 80000)
            {
                comissao = (venda * 0.14) + 650;
                Console.WriteLine("Comissao do vendedor: {0}", comissao);
            }

            if (venda < 80000 && venda >= 60000)
            {
                comissao = (venda * 0.14) + 600;
                Console.WriteLine("Comissao do vendedor:{0}", comissao); 
            }

            if (venda <60000 && venda >= 40000 )
            {
                comissao = (venda * 0.14) + 550;
                Console.WriteLine("Comissao do vendedor:{0}", comissao);
            }

            if (venda <40000 && venda >= 20000)
            {
                comissao = (venda * 0.14) + 500;
                Console.WriteLine("Comissao do vendedor:{0}", comissao);
            }
            if (venda < 2000)
            {
                comissao = (venda * 0.14) + 400;
                Console.WriteLine("Comissao do vendedor: {0}", comissao);
            }
        }
        
        static int Menu()
        {

            Console.WriteLine("*****Lista 2*****");

            Console.WriteLine("0 Sair");
            Console.WriteLine("1 - Exercicio A"); 
            Console.WriteLine("2 - Exercicio B"); 
            Console.WriteLine("3 - Exercicio C"); 
            Console.WriteLine("4 - Exercicio D");
            Console.WriteLine("5 - Exercicio E");
            Console.WriteLine("6 - Exercicio F");
            Console.WriteLine("7 - Exercicio G");
            Console.WriteLine("8 - Exercicio H");
            Console.WriteLine("9 - Exercicio I");
            Console.WriteLine("10 -Exercicio J");
            Console.WriteLine("11 -Exercicio K");

            Console.WriteLine("Escolha uma opcao: "); 

            return int .Parse(Console.ReadLine());  
        
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

                    case 1: ExA();
                        Console.ReadKey(); 

                        break;

                    case 2: ExB();
                        Console.ReadKey();

                        break;
                    
                    case 3: ExC();
                        Console.ReadKey();

                        break;

                    case 4: ExD();
                        Console.ReadKey();

                        break;
                    
                    case 5: ExE();
                        Console.ReadKey();

                        break; 
                    
                    case 6: ExF();
                        Console.ReadKey();

                        break;
                    
                    case 7: ExG();
                        Console.ReadKey();

                        break;
                    
                    case 8: ExH();
                        Console.ReadKey();

                        break;

                    case 9: ExI();
                        Console.ReadKey();

                        break;
                    
                    case 10: ExJ();
                        Console.ReadKey();

                        break; 
                    
                    case 11: ExK();
                        Console.ReadKey();

                        break; 

                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.ReadKey(); 

                        break;
                }

            } while (opcao != 0); 
        }
    }
}

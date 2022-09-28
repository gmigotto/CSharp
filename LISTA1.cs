using System;

namespace ProgramaLista1
{
    internal class Program
    { 
        static void EX12()
        {
            float altura;

            Console.WriteLine("Entre com a altura: "); 
            altura = float.Parse(Console.ReadLine());

            double homens, mulheres;

            homens = (72.7 * altura) - 58;
            mulheres = (62.1 * altura) - 44.7;

            Console.WriteLine("Peso ideal para mulheres: {}", mulheres);
            Console.WriteLine("Peso ideal para homens: {}", homens);

            Console.ReadKey();

        }
        static void EX11()
        {
           double invest = 1000, rendimento, rendimento2, rendimento3, rendimento4; 

            rendimento =invest / 0.124;

            rendimento2 = rendimento * 0.018;

            rendimento3 = rendimento2 * 0.056;

            rendimento4 = rendimento3 / 0.045;

            Console.WriteLine("O valor atual do investimento e: ", rendimento4);

            Console.ReadKey();

        }
        static void EX10()
        {
            int num;

            Console.WriteLine("Entre com um numero de 4 digitos"); 
            num = int.Parse(Console.ReadLine());

            int alg1, alg2, alg3, alg4;

            alg1 = num % 10; 
            num /= 10;
            alg2 = num % 10;
            num /= 10;
            alg3 = num % 10;
            num /= 10; 
            alg4 = num % 10;
            num/=10;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", alg1, alg2, alg3, alg4); 
            Console.ReadKey();

        }
        static void EX9() 
        {
            int sucessor, num, antecessor;

            Console.WriteLine("Entre com o  numero:"); 
            num = int.Parse(Console.ReadLine());
            
            antecessor = (num * 3) - 1;
            sucessor = (num * 2) + 1;

            int soma; 

            soma = antecessor + sucessor;

            Console.WriteLine("Soma: ", soma); 

            Console.ReadKey();


        }
        static void EX8()
        {
            float real;

            Console.WriteLine("Entre com o valor em REAL: ");
            real = float.Parse(Console.ReadLine());

            float cotacao;

            Console.WriteLine("Entre com a cotação do dolar: ");
            cotacao = float.Parse(Console.ReadLine());

            float dolar;

            dolar = real / cotacao;

            Console.WriteLine("Valor convertido em dolar:{0} ", dolar);

            Console.ReadKey();
        }
        static void EX7()
        {
            float salario;

            Console.WriteLine("Entre com seu salario atual:");
            salario = float.Parse(Console.ReadLine());

            double salario_novo;

            salario_novo = (salario * 0.337) + salario;

            Console.WriteLine("Seu novo salario sera: {0}", salario_novo);

            Console.ReadKey();

        }
        static void EX6()
        {
            float So, v, t;

            Console.WriteLine("** Entre com os valores para calcular a formula S = So + v.t **\n");

            Console.WriteLine("Entre com o coeficiente de espaço inicial:\n ");
            So = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a velociadade:\n");
            v = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o tempo de percurso:\n ");
            t = float.Parse(Console.ReadLine());

            float S;

            S = So + (v * t);

            Console.WriteLine("Posicao final {0}m", S);

            Console.ReadKey();

        }
        static void EX5()
        {
            int num1, num2, num3, peso1, peso2, peso3;

            Console.WriteLine("Entre com tres numeros:\n ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os tres pesos:\n");
            peso1 = int.Parse(Console.ReadLine());
            peso2 = int.Parse(Console.ReadLine());
            peso3 = int.Parse(Console.ReadLine());




            float media;

            media = num1 * peso1 + num2 * peso2 + num3 * peso3 / (num1 + num2 + num3);

            Console.WriteLine("Media ponderada: {0}", media);
            Console.ReadKey();
        }
        static void EX4()
        {

            float peso;

            Console.WriteLine("Entre com seu peso: ");
            peso = float.Parse(Console.ReadLine());

            float altura;

            Console.WriteLine("Entre com a sua altura:");
            altura = float.Parse(Console.ReadLine());



            float IMC;

            IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("Voce esta abaixo do peso\n");
            }

            if (IMC > 18.5 && IMC < 25)
            {
                Console.WriteLine("Voce esta no peso normal\n");
            }
            if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine("Voce esta acima do peso\n");
            }

            if (IMC > 30 && IMC < 35)
            {
                Console.WriteLine("Voce esta em obesidade I\n");
            }
            if (IMC > 35 && IMC < 40)
            {
                Console.WriteLine("Voce esta em obesidade II\n");
            }

            if (IMC > 40)
            {
                Console.WriteLine("Voce esta em obesidade morbida");
            }

            Console.ReadKey();
        }
        static void EX3()
        {
            float graus_float;

            Console.WriteLine("Adicione as temperaturas em Fahrenheit para converter em Celsius!\t");

            Console.WriteLine("Entre com a temperatura em valor decimal: ");
            graus_float = float.Parse(Console.ReadLine());

            double c;

            c = (graus_float - 32.0) * (5.0 / 9.0);

            int graus_int;
            Console.WriteLine("Entre com a temperatura em valor inteiro: ");
            graus_int = int.Parse(Console.ReadLine());

            int c1;

            c1 = (graus_int - 32) * (5 / 9);

            Console.WriteLine("Celsius em valor decimal {0}\nCelsius em valor inteiro {1}", c, c1);

            Console.ReadKey();

        }
        static void EX2()
        {
            float metros;

            Console.WriteLine("Entre com o valor em metros:");
            metros = float.Parse(Console.ReadLine());

            float centimetros;

            centimetros = metros * 100;

            float milimetros;

            milimetros = metros * 1000;

            Console.WriteLine("O valor em centimentros e {0}CM\nO valor em melimetros e {1}MM", centimetros, milimetros);

            Console.ReadKey();
        }
        static void Ex1()
            {
                float salario_minimo, salario;

                Console.WriteLine("Entre com o valor do salario minimo atual:");
                salario_minimo = float.Parse(Console.ReadLine());

                Console.WriteLine("Entre com seu salario:");
                salario = float.Parse(Console.ReadLine());



                double salario_liq;
                salario_liq = salario * 0.85;

                Console.WriteLine("Seu salario liquido e:{0}", salario_liq);

                double qtde_salario;

                qtde_salario = salario_liq / salario_minimo;



                Console.WriteLine("Voce recebe {0} salarios", qtde_salario);


                Console.ReadKey();
            }

        static int Menu()
        {
            Console.Clear(); // limpa a tela 
            Console.WriteLine("*** Lista 1 ***");

            Console.WriteLine("0 SAIR"); 
            Console.WriteLine("1 EX01");
            Console.WriteLine("2 EX02");
            Console.WriteLine("3 EX03");
            Console.WriteLine("4 EX04");
            Console.WriteLine("5 EX05");
            Console.WriteLine("6 EX06");
            Console.WriteLine("7 EX07");
            Console.WriteLine("8 EX08");
            Console.WriteLine("9 EX09");
            Console.WriteLine("10 EX10");
            Console.WriteLine("11 EX11");
            Console.WriteLine("12 EX12");

            Console.WriteLine("Escolha uma opcao: ");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                opcao = Menu();

                switch(opcao){
                    case 0: Console.WriteLine("Sessao encerrada!");
                        Console.ReadKey();
                        break;
                        
                    case 1: Ex1();
                        Console.ReadKey();
                        break; 

                    case 2: EX2(); 
                        Console.ReadKey();
                        break;

                    case 3: EX3();
                        Console.ReadKey();
                        break;
       
                    case 4: EX4(); 
                        Console.ReadKey();
                        break;
                    
                    case 5: EX5(); 
                        Console.ReadKey();
                        break;
                    
                    case 6: EX6(); 
                        Console.ReadKey();
                        break;
                        
                    case 7: EX7(); 
                        Console.ReadKey();
                        break;

                    case 8: EX8(); 
                        Console.ReadKey();
                        break;
                    
                    case 9: EX9(); 
                        Console.ReadKey();
                        break;
                    
                    case 10: EX10(); 
                        Console.ReadKey();
                        break;
                    
                    case 11: EX11(); 
                        Console.ReadKey();
                        break;
                    
                    case 12: EX12(); 
                        Console.ReadKey();
                        break;




                    default: Console.WriteLine("Opcao invalida");
                        Console.ReadKey();

                        break;  
                    


                }
            }while (opcao != 0);

        }
    }
}

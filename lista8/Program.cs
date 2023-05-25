using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
        }
        public static void Exercicio5()
        {
            Console.WriteLine("here ex5 will be encoded");
        }
        public static void Exercicio6()
        {
            Console.WriteLine("here ex6 will be encoded");
        }
        public static void Exercicio7()
        {
            Console.WriteLine("here ex7 will be encoded");
        }



        static void Main(string[] args)
        {
            int programa = 1;
            do
            {
                Console.WriteLine("qual exercício deseja executar? \ndigite 0 para finalizar todos\n");
                programa = int.Parse(Console.ReadLine());


                int op;
                Console.WriteLine("MENU LISTA 7");
                Console.WriteLine("ex 1");
                Console.WriteLine("ex 2");
                Console.WriteLine("ex 3");
                Console.WriteLine("ex 4");
                Console.WriteLine("ex 5");
                Console.WriteLine("ex 6");
                Console.WriteLine("ex 7");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        int q = 1, prodn, prod, total = 0, qnt = 0;

                        for (int i = 0; q > 0; i++)
                        {
                            Console.WriteLine("digite a quantidade de produtos");
                            prodn = int.Parse(Console.ReadLine());
                            Console.WriteLine("coloque o valor do produto");
                            prod = int.Parse(Console.ReadLine());

                            total = total + prod * prodn;
                            qnt = qnt * prodn;
                            Console.WriteLine("total: " + total);
                            Console.WriteLine("quantidade: " + prodn);
                        }
                        break;

                    case 2:

                        int produtos = 0, valor, maior = 0, menor = 0, totall = 0, parada = 0;
                        string nome, nomeMaior, nomeMenor;

                        do
                        {
                            Console.WriteLine("Digite o nome do produto: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("digite o valor do produto");
                            valor = int.Parse(Console.ReadLine());


                            totall = produtos * valor;
                            if (totall > maior)
                            {
                                maior = (int)totall;
                                nomeMaior = nome;
                            }
                            if (totall < menor)
                            {
                                menor = (int)totall;
                                nomeMenor = nome;
                            }

                            Console.WriteLine("deseja parar (S/N) ? :");
                            parada = int.Parse(Console.ReadLine());


                        } while (parada != 1);
                        break;

                    case 3:

                        Console.Write("insira a quantidade de avaliações: ");
                        int qntAvaliacoes = int.Parse(Console.ReadLine());

                        double soma = 0;

                        for (int i = 1; i <= qntAvaliacoes; i++)
                        {
                            Console.Write("insira o peso da avaliação {i}: ");
                            double peso1 = double.Parse(Console.ReadLine());
                            soma += peso1;
                        }

                        if (soma < 100)
                        {
                            Console.WriteLine("A soma dos pesos é insuficiente: {somaPesos}%");
                        }
                        else if (soma > 100)
                        {
                            Console.WriteLine("A soma dos pesos é excedente: {somaPesos}%");
                        }
                        else
                        {
                            Console.WriteLine("A soma dos pesos é adequada: 100%");

                        }
                        break;

                    case 4:
                        Console.Write("insira a sigla do estado: ");
                        string sigla = Console.ReadLine().ToUpper();

                        string completo;

                        switch (sigla)
                        {
                            case "AC":
                                completo = "Acre";
                                break;
                            case "AL":
                                completo = "Alagoas";
                                break;
                            case "AP":
                                completo = "Amapá";
                                break;
                            case "AM":
                                completo = "Amazonas";
                                break;
                            case "BA":
                                completo = "Bahia";
                                break;
                            case "CE":
                                completo = "Ceará";
                                break;
                            case "DF":
                                completo = "Distrito Federal";
                                break;
                            case "ES":
                                completo = "Espírito Santo";
                                break;
                            case "GO":
                                completo = "Goiás";
                                break;
                            case "MA":
                                completo = "Maranhão";
                                break;
                            case "MT":
                                completo = "Mato Grosso";
                                break;
                            case "MS":
                                completo = "Mato Grosso do Sul";
                                break;
                            case "MG":
                                completo = "Minas Gerais";
                                break;
                            case "PA":
                                completo = "Pará";
                                break;
                            case "PB":
                                completo = "Paraíba";
                                break;
                            case "PR":
                                completo = "Paraná";
                                break;
                            case "PE":
                                completo = "Pernambuco";
                                break;
                            case "PI":
                                completo = "Piauí";
                                break;
                            case "RJ":
                                completo = "Rio de Janeiro";
                                break;
                            case "RN":
                                completo = "Rio Grande do Norte";
                                break;
                            case "RS":
                                completo = "Rio Grande do Sul";
                                break;
                            case "RO":
                                completo = "Rondônia";
                                break;
                            case "RR":
                                completo = "Roraima";
                                break;
                            case "SC":
                                completo = "Santa Catarina";
                                break;
                            case "SP":
                                completo = "São Paulo";
                                break;
                            case "SE":
                                completo = "Sergipe";
                                break;
                            case "TO":
                                completo = "Tocantins";
                                break;
                            default:
                                completo = "";
                                break;
                        }

                        if (completo == "")
                        {
                            Console.WriteLine("essa sigla é iválida!");
                        }
                        else
                        {
                            Console.WriteLine($"O estado {sigla} é {completo}.");
                        }
                        break;


                    case 5:

                        Console.Write("insira um número de 1 a 12 referente ao mês escolhido: ");
                        int mes = int.Parse(Console.ReadLine());

                        switch (mes)
                        {
                            case 1:
                            case 2:
                            case 12:
                                Console.WriteLine("Verão");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("Outono");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("Inverno");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("Primavera");

                                break;
                            default:
                                Console.Write("Mês inválido. ");
                                break;
                        }

                        if (mes < 1 || mes > 12)
                        {
                            Console.WriteLine("Número fora do intervalo permitido.");
                        }
                        else
                        {
                            Console.WriteLine("Esse mês corresponde a duas estações. Digite \"1\" para Primavera/Verão ou \"2\" para Outono/Inverno.");
                            int estacao = int.Parse(Console.ReadLine());

                            switch (estacao)
                            {
                                case 1:
                                    Console.WriteLine("Verão");
                                    break;
                                case 2:
                                    Console.WriteLine("Inverno");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        break;



                    case 6:
                        Console.Write("Insira seu peso em kg: ");
                        double peso = double.Parse(Console.ReadLine());

                        Console.Write("Insira sua altura em metros: ");
                        double altura = double.Parse(Console.ReadLine());

                        double imc = peso / (altura * altura);

                        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

                        if (imc < 18.5)
                        {
                            Console.WriteLine("abaixo do peso.");
                        }
                        else if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine("peso normal.");
                        }
                        else if (imc >= 25.0 && imc <= 29.9)
                        {
                            Console.WriteLine("sobrepeso.");
                        }
                        else if (imc >= 30.0 && imc <= 34.9)
                        {
                            Console.WriteLine("obesidade grau 1.");
                        }
                        else if (imc >= 35.0 && imc <= 39.9)
                        {
                            Console.WriteLine("obesidade grau 2.");
                        }
                        else
                        {
                            Console.WriteLine("obesidade grau 3 (mórbida).");
                        }
                        break;



                    case 7:
                        Console.Write("insira um valor inteiro positivo: ");
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine("Divisores de " + n + ":");

                        for (int i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                            {
                                Console.WriteLine(i);
                                break;

                            }


                        }
                        break;
                }

            } while (programa != 0);










        }
    }
}



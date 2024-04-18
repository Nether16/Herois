using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_de_Herois
{
    class Program
    {
        static bool loop = true, montado = false;
        static int pontuação1, pontuação2, pontuação3, pontuação4, pontuação5, p1, p2, p3, quantidade;
        static string poder1, poder2, poder3, poder4, poder5,escolha1,escolha2,escolha3,escolha = "", heroi1 = "", heroi2 = "", heroi3 = "", heroi4 = "", heroi5 = "";
        static void Main(string[] args)
        {
            while (loop)
            {
                Console.WriteLine("[1]Cadastrar Herois\r\n[2]Montar equipe \r\n[3]Ver equipe \r\n[4]Sair");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Quantos Herois serão cadastrados (maximo 5)");
                        quantidade = int.Parse(Console.ReadLine());

                        if (quantidade > 5 || quantidade < 1)
                        {
                            Console.WriteLine($"Nao é possivel cadastrar {quantidade} Herois");
                        }
                        else
                        {
                            for (int i = 1; i <= quantidade; i++)
                            {
                                switch (i)
                                {
                                    case 1:
                                        Console.WriteLine($"Insira o nome do {i}º Heroi");
                                        heroi1 = Console.ReadLine();
                                        poder1 = EscolhadosHerois(i);
                                        Console.WriteLine("Insira a pontuação de missoes dele");
                                        pontuação1 = int.Parse(Console.ReadLine());
                                        break;
                                    case 2:
                                        Console.WriteLine($"Insira o nome do {i}º Heroi");
                                        heroi2 = Console.ReadLine();
                                        poder2 = EscolhadosHerois(i);
                                        Console.WriteLine("Insira a pontuação de missoes dele");
                                        pontuação2 = int.Parse(Console.ReadLine());
                                        break;
                                    case 3:
                                        Console.WriteLine($"Insira o nome do {i}º Heroi");
                                        heroi3 = Console.ReadLine();
                                        poder3 = EscolhadosHerois(i);
                                        Console.WriteLine("Insira a pontuação de missoes dele");
                                        pontuação3 = int.Parse(Console.ReadLine());
                                        break;
                                    case 4:
                                        Console.WriteLine($"Insira o nome do {i}º Heroi");
                                        heroi4 = Console.ReadLine();
                                        poder4 = EscolhadosHerois(i);
                                        Console.WriteLine("Insira a pontuação de missoes dele");
                                        pontuação4 = int.Parse(Console.ReadLine());
                                        break;
                                    case 5:
                                        Console.WriteLine($"Insira o nome do {i}º Heroi");
                                        heroi5 = Console.ReadLine();
                                        poder5 = EscolhadosHerois(i);
                                        Console.WriteLine("Insira a pontuação de missoes dele");
                                        pontuação5 = int.Parse(Console.ReadLine());
                                        break;
                                }

                            }
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        if (quantidade != 0)
                        {
                            Elenco(quantidade, heroi1, heroi2, heroi3, heroi4, heroi5, true);
                            montado = true;
                        }
                        else
                        {
                            Console.WriteLine("Cadastre herois primeiro antes de montar o time");
                        }
                        break;
                    case "3":
                        if (montado == true)
                        {
                            MontagemdeTime(escolha1, escolha2, escolha3, p1, p2, p3);
                        }
                        else
                        {
                            Console.WriteLine("Monte um time antes");
                        }
                        break;
                    case "4":
                        loop = false;
                        break;
                }
            }
        }
        static string EscolhadosHerois(int quant)
        {
            Console.WriteLine("Insira o poder dele");
            string Poder = Console.ReadLine();
            return $"tem o poder de {Poder}";
        }
        static void Elenco(int quant, string h1, string h2, string h3, string h4, string h5, bool Montagem)
        {
            for (int i = 1; i <= quant; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine(h1 + $" e tem uma pontução em missoes de {pontuação1}");
                        break;
                    case 2:
                        Console.WriteLine(h2 + $" e tem uma pontução em missoes de {pontuação2}");
                        break;
                    case 3:
                        Console.WriteLine(h3 + $" e tem uma pontução em missoes de {pontuação3}");
                        break;
                    case 4:
                        Console.WriteLine(h4 + $" e tem uma pontução em missoes de {pontuação4}");
                        break;
                    case 5:
                        Console.WriteLine($"O heroi {heroi1}" + h5 + $" e tem uma pontução em missoes de {pontuação5}");
                        break;
                }
            }
            if (Montagem == true)
            {
                Console.WriteLine("Escolha 3 dos herois para fazerem parte do seu time e coloque a pontuação deles");
                Console.Write("Primeiro Heroi : ");
                escolha1 = Console.ReadLine();
                Console.Write("Segundo Heroi : ");
                escolha2 = Console.ReadLine();
                Console.Write("Terceiro Heroi : ");
                escolha3 = Console.ReadLine();

                p1 = Checagem(escolha1, quant);
                p2 = Checagem(escolha2, quant);
                p3 = Checagem(escolha3, quant);
                MontagemdeTime(escolha1, escolha2, escolha3, p1, p2, p3);
            }
        }
        static void MontagemdeTime(string h1, string h2, string h3, int po1, int po2, int po3)
        {
            Console.WriteLine($"Voce montou um time com \r\n{h1} com uma pontuação de {po1}\r\n{h2} com uma pontuação de {po2}\r\n{h3} com uma pontuação de {po3}");
            int total = po1 + po2 + po3;
            Console.WriteLine($"A pontuação total de seu time é : {total}");
        }
        static int Checagem(string nome, int quant)
        {
            int pont = 0;
            for (int i = 1; i <= quant; i++)
            {
                switch (i)
                {
                    case 1: if (nome == heroi1) { pont = pontuação1; } break;
                    case 2: if (nome == heroi2) { pont = pontuação2; } break;
                    case 3: if (nome == heroi3) { pont = pontuação3; } break;
                    case 4: if (nome == heroi4) { pont = pontuação4; } break;
                    case 5: if (nome == heroi5) { pont = pontuação5; } break;
                }
            }
            return pont;
        }
    }
}
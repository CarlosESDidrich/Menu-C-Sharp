using System;

namespace ProjetoAVA
{
    class Program
    {

        static void Main(string[] args)
        {
            int opçao;



            {//MENU (Oferecer as opções de seleção das questoes)
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                     Algoritmos e Linguagem de Programação");
                Console.WriteLine("                                 Atividade Final");
                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                           MENU DE EXERCÍCIOS");

                    Console.WriteLine();
                    Console.WriteLine("  1 Exercício;");
                    Console.WriteLine("  2 Exercício;");
                    Console.WriteLine("  3 Exercício;");
                    Console.WriteLine("  4 Exercício;");
                    Console.WriteLine("  5 Exercício;");
                    Console.WriteLine("  6 Exercício;");
                    Console.WriteLine("  0 Sair do menu;");
                    Console.WriteLine();


                    Console.Write("  Digite o exercício desejado: ");
                    opçao = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (opçao)
                    {
                        case 1:
                            Console.WriteLine("  1.Some os números de 1 a 100 e imprima o valor.");
                            {
                                Exercício1();
                            }
                            break;

                        case 2:
                            Console.WriteLine("  2. Construa um Algoritmo que, para um grupo de 50 valores inteiros, determine:");
                            Console.WriteLine("     a) A soma dos números positivos;");
                            Console.WriteLine("     b) A quantidade de valores negativos;");
                            Console.WriteLine();
                            {
                                Exercício2();
                            }
                            break;

                        case 3:
                            Console.WriteLine("  3. Escreva um programa que verifique os números entre 1 e 1999 e mostra aqueles que divididos por 11 dão resto 5.");
                            Console.WriteLine();
                            {
                                Exercício3();
                            }
                            break;

                        case 4:
                            Console.WriteLine("  4. Faça um programa que leia vários inteiros positivos e mostre, no final, a soma dos números pares e a soma dos números ímpares.O programa para quando entrar um número maior que 1000.");
                            Console.WriteLine();
                            {
                                Exercício4();
                            }
                            break;
                        case 5:
                            Console.WriteLine("  5. Para uma turma de 45 alunos, construa um algoritmo que determine:");
                            Console.WriteLine("     a) A idade média dos alunos com menos de 1.60m de altura;");
                            Console.WriteLine("     b) A altura média dos alunos com mais de 18 anos.");
                            Console.WriteLine();
                            {
                                Exercício5();
                            }
                            break;

                        case 6:
                            Console.WriteLine("  6. Foi realizada uma pesquisa de algumas características físicas da população de umacerta região, a qual coletaram os seguintes dados referentes a cada habitante para serem analisados:");
                            Console.WriteLine("     a) Sexo (masculino e feminino)");
                            Console.WriteLine("     b) Cor dos olhos(azuis, verdes ou castanhos) - cor dos cabelos(louros, castanhos, pretos");
                            Console.WriteLine("     c) Idade");
                            Console.WriteLine();
                            Console.WriteLine("  Faça um algoritmo que determine e escreva:");
                            Console.WriteLine("     a) A maior idade entre os habitantes;");
                            Console.WriteLine("     b) A quantidade de indivíduos do sexo feminino cuja idade está entre 20 e 30 anos, inclusive;");
                            Console.WriteLine("     c) A quantidade de indivíduos que tenham olhos verdes e cabelos louros; ");
                            Console.WriteLine("  Para encerrar o programa peça ao usuário para digitar um número negativo.");
                            Console.WriteLine();
                            {
                                Exercício6();
                            }
                            break;

                        case 0:
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("                                          ... Obrigado, Aguardo nota máxima ;) ...");
                                Console.WriteLine("                                 ... Desenvolvedor:  Carlos Eduardo da Silva Didrich ...");
                                Console.WriteLine();
                                Console.WriteLine(".....................................Para fechar o programa pressione qualquer tecla....................................");
                                Console.ReadKey();
                            }
                            break;

                        default:
                            Console.WriteLine("    ...Exercício selecionado não foi encontrado!...");
                            Console.WriteLine("  ...Por gentileza insira um número entre as opções...");
                            break;
                    }

                } while (opçao != 0);

                //------------------------------------------------Exercícios Resoluções:-------------------------------------------------------------------------------

                static void Exercício1()
                {
                    int soma = 0;

                    for (int i = 1; i <= 100; i++)
                    {
                        soma = soma + i;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"  A soma dos números é de {soma}");
                }

                static void Exercício2()
                {
                    int soma_posi = 0, quant_negativos = 0;

                    for (int i = 0; i < 50; i++)
                    {
                        Console.Write("  Digite um valor positivo ou negativo: ");
                        int valor = Convert.ToInt32(Console.ReadLine());

                        if (valor > 0)
                        {
                            soma_posi = (soma_posi + valor);
                        }

                        if (valor < 0)
                        {
                            quant_negativos++;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"  A soma dos valores positivos é: {soma_posi}");
                    Console.WriteLine($"  A quantidade de valores negativos é: {quant_negativos}");
                }

                static void Exercício3()
                {
                    Console.WriteLine("  Números entre 1 e 1999, divisíveis por 11 e com resto 5:");
                    int resto;

                    for (int i = 1; i <= 1999; i++)
                    {
                        resto = i % 11;

                        if (resto == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine(i);
                        }
                    }
                }

                static void Exercício4()
                {
                    int num_lido = 0;
                    int soma_par = 0, soma_impar = 0;

                    do
                    {
                        Console.Write("  Digite um valor: ");
                        num_lido = Convert.ToInt16(Console.ReadLine());

                        if (num_lido % 2 == 0)
                        {
                            soma_par = (soma_par + num_lido);
                        }

                        else
                        {
                            soma_impar = (soma_impar + num_lido);
                        }
                    } while (num_lido <= 1000);

                    Console.WriteLine();
                    Console.WriteLine($"  A soma dos valores pares é:{soma_par}");
                    Console.WriteLine($"  A soma dos valores impares é: {soma_impar}");
                }

                static void Exercício5()
                {

                    // 5.Para uma turma de 45 alunos, construa um algoritmo que determine: ");
                    // a) A idade média dos alunos com menos de 1,60m de altura;");
                    // b) A altura média dos alunos com mais de 18 anos.");


                    int i, idade18, altura160;
                    float altura, media_altura, idade, media_idade;
                    i = 0; idade18 = 0; altura160 = 0;
                    idade = 0; altura = 0; media_altura = 0; media_idade = 0;

                    for (i = 1; i <= 45; i++)
                    {

                        Console.Write($"  idade do aluno: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"  altura do aluno: ");
                        altura = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();



                        if (idade > 18)
                        {
                            ++idade18;
                            media_altura += altura;
                        }
                        if (altura < 160)
                        {
                            ++altura160;
                            media_idade += idade;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("  Altura média dos alunos com mais de 18 anos: " + media_altura / idade18);
                    Console.WriteLine("  A idade média dos alunos com menos de 1.60 m de altura: " + media_idade / altura160);

                }

                static void Exercício6()
                {
                    //  6.Foi realizada uma pesquisa de algumas características físicas da população de uma certa região, a qual coletaram os seguintes dados referentes a cada habitante para serem analisados:");
                    //    a) Sexo (masculino e feminino)");
                    //     b) Cor dos olhos(azuis, verdes ou castanhos) - cor dos cabelos(louros, castanhos, pretos");
                    //     c) Idade");
                    //
                    //  Faça um algoritmo que determine e escreva:");
                    //     a) A maior idade entre os habitantes;");
                    //     b) A quantidade de indivíduos do sexo feminino cuja idade está entre 20 e 30 anos, inclusive;");
                    //     c) A quantidade de indivíduos que tenham olhos verdes e cabelos louros; ");

                    Console.Write("  Quantidade de pessoas na pesquisa: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int maior = 0, idade;
                    int quant_fem = 0;
                    int quant_loiroverde = 0;


                    for (int i = 0; i < quantidade; i++)
                    {
                        //idade; 
                        Console.Write("  Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());


                        if (idade > maior)
                        {
                            maior = idade;
                        }

                        //sexo
                        char sexo;

                        do
                        {
                            Console.Write("  Sexo: M ou F: ");
                            sexo = Convert.ToChar(Console.ReadLine());

                        } while ((sexo != 'M') && (sexo != 'F'));

                        if ((idade >= 20) && (idade <= 30))
                        {
                            if (sexo == 'F')
                            {
                                quant_fem++;
                            }
                        }

                        char olhos, cabelo;


                        // Olhos e cabelo;
                        {

                            do
                            {
                                Console.Write("  Olhos: A- Azul, V- Verde, C- Castanho: ");
                                olhos = Convert.ToChar(Console.ReadLine());
                                Console.Write("  Cabelo: L- Loiro, C- Castanho, P- Preto: ");
                                cabelo = Convert.ToChar(Console.ReadLine());
                                Console.WriteLine();


                                if ((olhos == 'V') && (cabelo == 'L'))
                                {
                                    quant_loiroverde++;
                                }

                            } while ((olhos == 'A') && (olhos == 'V') && (olhos == 'C') && (cabelo == 'L') && (cabelo == 'C') && (cabelo == 'P'));
                        }
                    }
                    Console.WriteLine($"  A maior idade entre os habitantes é: {maior}");
                    Console.WriteLine($"  A quantidade de mulheres entre os 20 e 30 anos é {quant_fem}");
                    Console.WriteLine($"  A quantidade de habitantes com olhos verder e cabelos loiros é {quant_loiroverde}");
                }
            }
        }
    }
}    


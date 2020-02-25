using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questoes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            var visualizarQuestao = string.Empty;
            while (continuar)
            {
                Console.WriteLine("Digite o número da questão deseja Visualizar: ");
                var opcao = 0;
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        PrimeiraQuestao();
                        Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 2:
                        SegundaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 3:
                        TerceiraQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 4:
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;
                        
                    case 5:
                        QuintaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 6:
                        SextaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 7:
                        SetimaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 8:
                        OitavaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 9:
                        NonaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;

                    case 10:
                        DecimaQuestao();
                       Console.WriteLine("Deseja Visualizar outra questão? Sim{s}, Não{n}");
                        visualizarQuestao = Console.ReadLine();
                        if (visualizarQuestao.Equals("s"))
                        {
                            continuar = true; break;
                        }
                        else continuar = false; break;
                }
            }


        }

        #region .: Metodos :.

        //ok
        static void PrimeiraQuestao()
        {
            int numero = 0;
            int numeroInicio = 0;
            List<int> arrayNumeros = new List<int>();

            Console.WriteLine("Qual o número que deseja?");
            numeroInicio = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                if (i.Equals(0))
                {
                    arrayNumeros.Add(numeroInicio);
                    if (numeroInicio.Equals(0))
                    {
                        numeroInicio = numeroInicio + 1;
                        Console.WriteLine(arrayNumeros[0]);
                    }
                    else
                    {
                        numeroInicio = numeroInicio + numeroInicio;
                        Console.WriteLine(arrayNumeros[0]);
                    }
                }
                if (!i.Equals(0))
                {
                    numero = i - 1;
                    numero = arrayNumeros[numero];
                    arrayNumeros.Add(numeroInicio);
                    numeroInicio = numero + arrayNumeros[i];
                    Console.WriteLine(arrayNumeros[i]);
                }
            }
            Console.ReadKey();
        }
        //ok
        static void SegundaQuestao()
        {
            Console.WriteLine("Irei criar um arquivo .txt em branco. Aperte ENTER para continuar.");
            var nomeArquivo = string.Empty;
            nomeArquivo = "Questao2 - Kaua-" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + nomeArquivo;

            if (!Directory.Exists($@"{path}\{nomeArquivo.Trim()}"))
            {
                System.IO.File.Create($@"{path.Trim()}");
            }
            else
            {
                Directory.Delete(path.Replace(@"\\", @"\"));
                System.IO.File.Create($@"{path.Trim()}");
            }
            Console.WriteLine($@"Diretorio Criado: {path.Trim()}");
            Console.ReadLine();
        }
        //ok
        static void TerceiraQuestao()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("Entre com o primeiro parametro: ");
            int coluna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o segundo parametro: ");
            int linha = Convert.ToInt32(Console.ReadLine());
            string[,] matriz = new string[coluna, linha];
            int numero = 1;
            int contNumero = linha;
            int contColuna = coluna;
            var file = string.Empty;

            for (int col = 0; col < coluna; col++)
            {
                for (int row = 0; row < linha; row++)
                {
                    matriz[col, row] = numero.ToString();
                    numero++;
                }
            }

            File.Delete($@"{path}\Questão 3 - Matriz -Kauã.txt");

            foreach (var item in matriz)
            {
                if (coluna % 2 == 0)
                {
                    if (item.Equals(contNumero.ToString()))
                    {
                        contNumero += linha;
                        file = item + ',';
                        file = file.TrimEnd(',', ' ');
                        File.AppendAllText($@"{path}\Questão 3 - Matriz -Kauã.txt", $"{file.Trim()}\r ");

                    }
                    else
                    {

                        File.AppendAllText($@"{path}\Questão 3 - Matriz -Kauã.txt", $"{item.Trim().TrimEnd(',', ' ')}, ");
                    }
                }
                else
                {
                    if (item.Equals(contColuna.ToString()))
                    {
                        contColuna += coluna;
                        var fileAux = item + ",";
                        fileAux = fileAux.TrimEnd(',', ' ');
                        File.AppendAllText($@"{path}\Questão 3 - Matriz -Kauã.txt", $"{fileAux}\r\n ");
                    }
                    else
                    {
                        File.AppendAllText($@"{path}\Questão 3 - Matriz -Kauã.txt", $"{item} ");
                    }
                }

            }
            Console.WriteLine($@"Caminho do arquivo criado com informações: {path}\Questão 3 - Matriz -Kauã.txt");
            Console.ReadLine();
        }
        //ok
        static void QuartaQuestao()
        {
            Console.WriteLine("Escreva qualquer palavra, pois criarei um repetição para adicionar no arquivo e ler a primeira linha.");
            var texto = Console.ReadLine();
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Questao4 -Kaua.txt";
            string primeiraLinha = string.Empty;
            File.Delete(path);
            if (!Directory.Exists(path))
            {
                for (int i = 0; i <= 20; i++)
                {
                    File.AppendAllText(path, texto.ToString() + "\r\n");
                }

                var linesFile = File.ReadAllLines(path);
                primeiraLinha = linesFile[0];

                Console.WriteLine($"A primeira tem como conteúdo : {primeiraLinha}\r\nO arquivo que foi criado com o texto inserido é: {path}");
                Console.ReadKey();
            }
        }
        //ok
        static void QuintaQuestao()
        {
            Console.WriteLine("Escreva qualquer palavra, pois criarei um repetição para adicionar no arquivo o conteudo e ler a quantidade linha.");
            var texto = Console.ReadLine();
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Questao5 -Kaua.txt";
            int qtdeLinhas = 0;
            File.Delete(path);
            if (!Directory.Exists(path))
            {

                for (int i = 0; i < 20; i++)
                {
                    File.AppendAllText(path, texto.ToString() + "\r\n");
                }

                var linesFile = File.ReadAllLines(path);

                qtdeLinhas = linesFile.Length;

                Console.WriteLine($"A Quantidade de linhas é: {qtdeLinhas}\r\n O arquivo criado é {path}");
                Console.ReadLine();
            }

        }
        //conferir (FAZER)
        static void SextaQuestao()
        {
            var cidade = 0;
            var rota = 0;
            object[] variaveis = new object[7];
            bool cidadeEncontrada = false;
            bool naoContemErro = false;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("N");
                variaveis[0] = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(variaveis[0]) < 4 || Convert.ToInt32(variaveis[0]) > 250)
                {
                    continuar = true;
                    Console.WriteLine("Primeiro numero não é valido");
                }

                Console.WriteLine("M");
                variaveis[1] = Convert.ToInt32(Console.ReadLine());
                var multToM = (Convert.ToInt32(variaveis[0]) * (Convert.ToInt32(variaveis[0]) - 1)) / 2;

                if (Convert.ToInt32(variaveis[1]) < 3 || Convert.ToInt32(variaveis[1]) > multToM)
                {
                    continuar = true;
                    Console.WriteLine("Segundo numero não é valido");
                }

                Console.WriteLine("C");
                variaveis[2] = Convert.ToInt32(Console.ReadLine());
                var multToC = Convert.ToInt32(variaveis[0]) - 1;

                if (Convert.ToInt32(variaveis[2]) < 2 || Convert.ToInt32(variaveis[2]) > multToC)
                {
                    continuar = true;
                    Console.WriteLine("Terceiro numero não é valido");
                }

                Console.WriteLine("K");
                variaveis[3] = Convert.ToInt32(Console.ReadLine());
                var multToK = Convert.ToInt32(variaveis[0]) - 1;

                if (Convert.ToInt32(variaveis[3]) < Convert.ToInt32(variaveis[2]) || Convert.ToInt32(variaveis[3]) > multToK)
                {
                    continuar = true;
                    Console.WriteLine("Quarto numero não é valido");
                }

                Console.WriteLine("U");
                variaveis[4] = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(variaveis[4]) < 0)
                {
                    continuar = true;
                    Console.WriteLine("Quinto numero não é valido");
                }

                Console.WriteLine("V");
                variaveis[5] = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(variaveis[5]) > multToC || Convert.ToInt32(variaveis[5]).Equals(Convert.ToInt32(variaveis[4])))
                {
                    continuar = true;
                    Console.WriteLine("Sexto numero não é valido");
                }

                Console.WriteLine("P");
                variaveis[6] = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(variaveis[6]) < 0 || Convert.ToInt32(variaveis[6]) > 250)
                {
                    continuar = true;
                    Console.WriteLine("Setimo numero não é valido");
                }

                if (!naoContemErro)
                {
                    continuar = false;
                }
                if (!naoContemErro)
                {

                    while (!cidadeEncontrada)
                    {
                        var cont = 0;
                        var encontrarCidade = Convert.ToInt32(variaveis[0]) - 1;
                        var encontrarRotaServico = Convert.ToInt32(variaveis[2]) - 1;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Convert.ToInt32(variaveis[cont]) >= 0 && Convert.ToInt32(variaveis[cont]) <= encontrarCidade)
                            {
                                Console.WriteLine($"FOI ENCONTRADO A CIDADE NA POSIÇÃO {cidade = Convert.ToInt32(variaveis[cont])}");
                                i++;
                                cidadeEncontrada = true;
                                cont = cont + 1;
                            }
                            if (Convert.ToInt32(variaveis[cont]) >= 0 && Convert.ToInt32(variaveis[cont]) <= encontrarRotaServico)
                            {
                                Console.WriteLine($"FOI ENCONTRADO A ROTA NA POSIÇÃO {rota = Convert.ToInt32(variaveis[cont])}");

                            }
                            cont++;
                        }
                    }


                    Console.WriteLine($"{variaveis[0]} {variaveis[1]} {variaveis[2]} {variaveis[3]}");
                    Console.ReadLine();

                }

            }
        }
        //ok
        static void SetimaQuestao()
        {

            int qtdeCriancas = 0;
            int qtdeDesejo = 0;
            var contCrianca = 10;
            var contDesejo = 10;
            var AB = true;
            bool start = true;
            var a = 0;
            var b = 0;

            for (int i = 0; i <= 9; i++)
                contCrianca *= 10;
            for (int i = 0; i < 5; i++)
                contDesejo *= 10;

            do
            {
                Console.WriteLine("Digite o numero de crianças.");
                qtdeCriancas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero de Desejos.");
                qtdeDesejo = Convert.ToInt32(Console.ReadLine());

                if (qtdeCriancas > 3 || qtdeCriancas < contCrianca || qtdeDesejo < contDesejo || qtdeDesejo > 0)
                {
                    if (qtdeCriancas % 2 != 0)
                    {
                        Console.WriteLine("Y");
                        start = false;
                    }
                    else
                    {
                        Console.WriteLine("N");
                        start = false;
                    }
                }


            } while (start);

            do
            {
                Console.WriteLine("Digite o numero de crianças.");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero de Desejos.");
                b = Convert.ToInt32(Console.ReadLine());

                if (b >= a && b <= qtdeCriancas)
                {
                    Console.WriteLine("Y");
                }
                else
                {
                    Console.WriteLine("N");
                }
                if (a.Equals(0) && b.Equals(0))
                {
                    AB = false;
                }
            } while (AB);
        }
        //Tentar fazer Novamente(Logica)
        static void OitavaQuestao()
        {
            int N = 0;
            int M = 0;
            int Qi = 0;
            string QiNome = string.Empty;
            int pj = 0;
            string pjNome = string.Empty;
            bool finish = true;
            bool aux = true;
            List<string> conexoes = new List<string>();
            List<string> db = new List<string>();

            N = Convert.ToInt32(Console.ReadLine());
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((N + M) - 1);
            var cont = 0;
            do
            {

                Qi = Convert.ToInt32(Console.ReadLine());
                QiNome = Console.ReadLine();
                pj = Convert.ToInt32(Console.ReadLine());
                pjNome = Console.ReadLine();


                if (N >= 0 && M <= 200 && Qi >= 0 && Qi <= 100 && QiNome.Length <= 20 && pj >= 0 && pj <= 100 && pjNome.Length <= 20)
                {
                    db.Add(Qi + QiNome);
                    db.Add(pj + pjNome);
                    if (conexoes.Count.Equals(0))
                    {
                        conexoes.Add(Qi.ToString() + QiNome);
                        conexoes.Add(pj.ToString() + pjNome);
                    }
                    else
                    {
                        for (var i = 0; i <= conexoes.Count; i++)
                        {
                            aux = true;
                            while (aux)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    cont += 1;
                                    if (i.Equals(0))
                                    {
                                        if (conexoes[i] != db[cont - 1])
                                        {
                                            conexoes.Add(Qi.ToString() + QiNome);
                                            conexoes.Add(pj.ToString() + pjNome);
                                            aux = false;
                                            break;
                                        }

                                        i++;
                                    }
                                    else
                                    {
                                        if (i <= conexoes.Count)
                                        {
                                            if (conexoes[i - 1] != db[cont - 1])
                                            {
                                                conexoes.Add(Qi.ToString() + QiNome);
                                                conexoes.Add(pj.ToString() + pjNome);
                                                aux = false;
                                                break;
                                            }
                                        }

                                    }
                                    aux = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (N.Equals(M) && M.Equals(0))
                {
                    finish = false;
                }
            } while (finish);
            Console.WriteLine(conexoes.Count);
            Console.ReadKey();
        }
        //Tentar fazer Novamente(Logica)
        static void NonaQuestao()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            var ponto1 = Convert.ToInt32(Console.ReadLine());

            var ponto2 = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 10000)
            {
                ponto1 = ponto1 * ponto1;
                ponto2 = ponto2 * ponto2;
                var pontoFinal = ponto1 + ponto2;

            }
        }
        //Tentar fazer Novamente(Logica)
        static void DecimaQuestao()
        {
            List<int> numeros = new List<int>();
            var num = 0;
            var cont = 10;
            var aux = 0;
            bool auxBool = true;

            for (int i = 0; i <= cont; i++)
            {
                Console.Write("Digite :");
                num = Convert.ToInt32(Console.ReadLine());
                numeros.Add(num);
                auxBool = true;
                aux += 1;
                while (auxBool)
                {
                    if (num % 2 != 0 || numeros[i] % 2 != 0)
                    {
                        Console.Write("Digite :");
                        num = Convert.ToInt32(Console.ReadLine());
                        numeros[i] = num;
                    }
                    else
                    {
                        auxBool = false;
                    }
                }
            }
        }
        #endregion
    }
}


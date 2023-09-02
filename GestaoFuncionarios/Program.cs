using System;

namespace SistemaGestaoRegistrosFuncionarios
{
    class Program
    {
        static string[] id = new string[30];
        static string[] nome = new string[30];
        static string[] endereco = new string[50];
        static string[] dataNascimento = new string[30];
        static string[] celular = new string[30];
        static string[] dataAdmissao = new string[30];
        static string[] estadoCivil = new string[30];
        static string[] departamentoTrabalho = new string[30];
        static string[] localTrabalho = new string[40];
        static string[] ctc = new string[30];
        static string[] seguroSocial = new string[30];
        static string[] email = new string[30];
        static int total = 0;

        static void InserirDados()
        {
            Console.WriteLine("Quantos Dados de Funcionários Deseja Inserir?");
            int ch = int.Parse(Console.ReadLine());

            if (total == 0)
            {
                total += ch;

                for (int i = 0; i < ch; i++)
                {
                    Console.WriteLine($"\nInserir Dados do Funcionário {i + 1}\n");
                    Console.WriteLine("** DETALHES PESSOAIS **\n");

                    Console.WriteLine("Inserir Nome:");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Endereço:");
                    endereco[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Data de Nascimento:");
                    dataNascimento[i] = Console.ReadLine();

                    Console.WriteLine("O Funcionário é Casado? (Sim ou Não):");
                    estadoCivil[i] = Console.ReadLine();

                    Console.WriteLine("** DETALHES DO TRABALHO **\n");

                    Console.WriteLine("Inserir Id:");
                    id[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Data de Admissão:");
                    dataAdmissao[i] = Console.ReadLine();

                    Console.WriteLine("Departamento de Trabalho:");
                    departamentoTrabalho[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Local de Trabalho:");
                    localTrabalho[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Salário (CTC):");
                    ctc[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Número de Seguro Social:");
                    seguroSocial[i] = Console.ReadLine();

                    Console.WriteLine("** DETALHES DE CONTATO **\n");

                    Console.WriteLine("Inserir Número de Celular:");
                    celular[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Email:");
                    email[i] = Console.ReadLine();
                }
            }
            else
            {
                for (int i = total; i < ch + total; i++)
                {
                    Console.WriteLine($"\nInserir Dados do Funcionário {i + 1}\n");
                    Console.WriteLine("** DETALHES PESSOAIS **\n");

                    Console.WriteLine("Inserir Nome:");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Endereço:");
                    endereco[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Data de Nascimento:");
                    dataNascimento[i] = Console.ReadLine();

                    Console.WriteLine("O Funcionário é Casado? (Sim ou Não):");
                    estadoCivil[i] = Console.ReadLine();

                    Console.WriteLine("** DETALHES DO TRABALHO **\n");

                    Console.WriteLine("Inserir Id:");
                    id[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Data de Admissão:");
                    dataAdmissao[i] = Console.ReadLine();

                    Console.WriteLine("Departamento de Trabalho:");
                    departamentoTrabalho[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Local de Trabalho:");
                    localTrabalho[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Salário (CTC):");
                    ctc[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Número de Seguro Social:");
                    seguroSocial[i] = Console.ReadLine();

                    Console.WriteLine("** DETALHES DE CONTATO **\n");

                    Console.WriteLine("Inserir Número de Celular:");
                    celular[i] = Console.ReadLine();

                    Console.WriteLine("Inserir Email:");
                    email[i] = Console.ReadLine();
                }

                total += ch;
            }
        }

        static void MostrarDados()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum Dado Foi Inserido");
            }
            else
            {
                for (int i = 0; i < total; i++)
                {
                    Console.WriteLine("** RESULTADO PARA MOSTRAR DADOS **");
                    Console.WriteLine($"\nDados do Funcionário: {i + 1}\n");
                    Console.WriteLine("** DETALHES PESSOAIS **\n");
                    Console.WriteLine($"Nome Completo: {nome[i]}");
                    Console.WriteLine($"Endereço: {endereco[i]}");
                    Console.WriteLine($"Data de Nascimento: {dataNascimento[i]}");
                    Console.WriteLine($"Estado Civil: {estadoCivil[i]}\n");
                    Console.WriteLine("** DETALHES DO TRABALHO **\n");
                    Console.WriteLine($"Id: {id[i]}");
                    Console.WriteLine($"Data de Admissão: {dataAdmissao[i]}");
                    Console.WriteLine($"Departamento de Trabalho: {departamentoTrabalho[i]}");
                    Console.WriteLine($"Local de Trabalho: {localTrabalho[i]}");
                    Console.WriteLine($"Salário (CTC): {ctc[i]}");
                    Console.WriteLine($"Número de Seguro Social: {seguroSocial[i]}\n");
                    Console.WriteLine("** DETALHES DE CONTATO **\n");
                    Console.WriteLine($"Número de Celular: {celular[i]}");
                    Console.WriteLine($"Email: {email[i]}\n");
                }
            }
        }

        static void PesquisarDados()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum dado foi inserido");
            }
            else
            {
                Console.WriteLine("Inserir o Id do Funcionário que Deseja Pesquisar:");
                string idd = Console.ReadLine();

                for (int i = 0; i < total; i++)
                {
                    if (idd == id[i])
                    {
                        Console.WriteLine($"RESULTADO PARA ID DO FUNCIONÁRIO: {idd}");
                        Console.WriteLine("** DETALHES PESSOAIS **\n");
                        Console.WriteLine($"Nome Completo: {nome[i]}");
                        Console.WriteLine($"Endereço: {endereco[i]}");
                        Console.WriteLine($"Data de Nascimento: {dataNascimento[i]}");
                        Console.WriteLine($"Estado Civil: {estadoCivil[i]}\n");
                        Console.WriteLine("** DETALHES DO TRABALHO **\n");
                        Console.WriteLine($"Id: {id[i]}");
                        Console.WriteLine($"Data de Admissão: {dataAdmissao[i]}");
                        Console.WriteLine($"Departamento de Trabalho: {departamentoTrabalho[i]}");
                        Console.WriteLine($"Local de Trabalho: {localTrabalho[i]}");
                        Console.WriteLine($"Salário (CTC): {ctc[i]}");
                        Console.WriteLine($"Número de Seguro Social: {seguroSocial[i]}\n");
                        Console.WriteLine("** DETALHES DE CONTATO **\n");
                        Console.WriteLine($"Número de Celular: {celular[i]}");
                        Console.WriteLine($"Email: {email[i]}");
                    }
                }
            }
        }

        static void AtualizarDados()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum dado foi inserido");
            }
            else
            {
                Console.WriteLine("Inserir o Id do Funcionário que Deseja Atualizar:");
                string rollno = Console.ReadLine();

                for (int i = 0; i < total; i++)
                {
                    if (rollno == id[i])
                    {
                        Console.WriteLine("\nDados Anteriores:\n");
                        Console.WriteLine($"Dados do Funcionário {i + 1}");
                        Console.WriteLine("** DETALHES PESSOAIS **");
                        Console.WriteLine($"Nome Completo: {nome[i]}");
                        Console.WriteLine($"Endereço: {endereco[i]}");
                        Console.WriteLine($"Data de Nascimento: {dataNascimento[i]}");
                        Console.WriteLine($"Estado Civil: {estadoCivil[i]}\n");
                        Console.WriteLine("** DETALHES DO TRABALHO **");
                        Console.WriteLine($"Id: {id[i]}");
                        Console.WriteLine($"Data de Admissão: {dataAdmissao[i]}");
                        Console.WriteLine($"Departamento de Trabalho: {departamentoTrabalho[i]}");
                        Console.WriteLine($"Local de Trabalho: {localTrabalho[i]}");
                        Console.WriteLine($"Salário (CTC): {ctc[i]}");
                        Console.WriteLine($"Número de Seguro Social: {seguroSocial[i]}\n");
                        Console.WriteLine("** DETALHES DE CONTATO **");
                        Console.WriteLine($"Número de Celular: {celular[i]}");
                        Console.WriteLine($"Email: {email[i]}\n");
                        Console.WriteLine("Inserir novos dados:\n");
                        Console.WriteLine("** DETALHES PESSOAIS **");
                        Console.WriteLine("Inserir Nome:");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Endereço:");
                        endereco[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Data de Nascimento:");
                        dataNascimento[i] = Console.ReadLine();
                        Console.WriteLine("O Funcionário é Casado? (Sim ou Não):");
                        estadoCivil[i] = Console.ReadLine();
                        Console.WriteLine("** DETALHES DO TRABALHO **");
                        Console.WriteLine("Inserir Id:");
                        id[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Data de Admissão:");
                        dataAdmissao[i] = Console.ReadLine();
                        Console.WriteLine("Departamento de Trabalho:");
                        departamentoTrabalho[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Local de Trabalho:");
                        localTrabalho[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Salário (CTC):");
                        ctc[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Número de Seguro Social:");
                        seguroSocial[i] = Console.ReadLine();
                        Console.WriteLine("** DETALHES DE CONTATO **");
                        Console.WriteLine("Inserir Número de Celular:");
                        celular[i] = Console.ReadLine();
                        Console.WriteLine("Inserir Email:");
                        email[i] = Console.ReadLine();
                    }
                }
            }
        }

        static void DeletarDados()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum dado foi inserido ainda");
            }
            else
            {
                Console.WriteLine("Tem Certeza de Que Deseja Deletar os Dados?");
                Console.WriteLine("Pressione 1 para deletar todos os registros");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    total = 0;
                    Console.WriteLine("Todos os registros foram deletados..!!");
                }
                else
                {
                    Console.WriteLine("Por favor, Pressione 1 para Deletar Todos os Registros");
                }
            }
        }

        static void Main(string[] args)
        {
            int amostra;
            Console.WriteLine("DIGITE 1: Para Continuar..");
            amostra = int.Parse(Console.ReadLine());

            while (amostra < 2)
            {
                Console.WriteLine(">>>>>>>>  SISTEMA DE GERENCIAMENTO DE REGISTROS DE FUNCIONÁRIOS  <<<<<<<<");
                Console.WriteLine("\nPRESSIONE 1: Para Inserir dados");
                Console.WriteLine("-------------------------");
                Console.WriteLine("PRESSIONE 2: Para Mostrar dados");
                Console.WriteLine("-------------------------");
                Console.WriteLine("PRESSIONE 3: Para Pesquisar dados");
                Console.WriteLine("-------------------------");
                Console.WriteLine("PRESSIONE 4: Para Atualizar dados");
                Console.WriteLine("-------------------------");
                Console.WriteLine("PRESSIONE 5: Para Deletar dados");
                Console.WriteLine("-------------------------");
                Console.WriteLine("PRESSIONE 6: Para Sair");
                Console.WriteLine("-------------------------");
                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        InserirDados();
                        break;

                    case 2:
                        MostrarDados();
                        break;

                    case 3:
                        PesquisarDados();
                        break;

                    case 4:
                        AtualizarDados();
                        break;

                    case 5:
                        DeletarDados();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Entrada Inválida");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_de_banco
{
    class Cliente
    {
        // variaveis e vetores
        public int i;
        public String[] nome = new String[10];
        public int[] conta = new int[10];
        public int[] agencia = new int[10];
        public int[] id = new int[10];

        public void addcliente()
        {
            string leitura;  // variavel para continuar adicionando clientes

            do
            {
                if (i < 10)
                {


                    Console.Clear();
                    Console.WriteLine("============================");
                    Console.WriteLine("|Digite o nome do cliente: |");
                    Console.WriteLine("============================");

                    nome[i] = Console.ReadLine();

                    Console.WriteLine("=============================");
                    Console.WriteLine("|Digite a conta do cliente: |");
                    Console.WriteLine("=============================");

                    conta[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("===============================");
                    Console.WriteLine("|Digite a agência do cliente: |");
                    Console.WriteLine("===============================");

                    agencia[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("=============================");
                    Console.WriteLine("|Digite a idade do cliente: |");
                    Console.WriteLine("=============================");

                    id[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("|Você deseja adicionar outro cliente? digite 's' para sim e 'n' para não: |");
                    Console.WriteLine("===========================================================================");

                    i++;
                    leitura = Console.ReadLine();
                }
                else // obriga a atender clientes
                {
                    Console.WriteLine("=================================================================");
                    Console.WriteLine("|A fila está cheia, atenda alguns clientes para a fila continuar|");
                    Console.WriteLine("=================================================================");
                    Console.WriteLine("|Digite n para voltar ao menu|");
                    Console.WriteLine("==============================");
                    leitura = Console.ReadLine();
                    Console.Clear();
                }



            } while (leitura.ToString().ToLower() != "n");
        }

        public void mostrarfila()
        {
            int aux;
            for (aux = 0; aux < 10; aux++)
            {
                Console.WriteLine("Cliente de nome: {0} - idade: {1} anos - agência: {2} - conta: {3}", nome[aux], id[aux], agencia[aux], conta[aux]);
                Console.WriteLine("==================================================================================");
            }
        }

        public void atendercliente()
        {
            Console.Clear();
            for (int y = 0; y < 10; y++)
            {
                int k = 0;
                if (y < 9)
                {
                    k = y + 1;
                    nome[y] = nome[k];
                    id[y] = id[k];
                    agencia[y] = agencia[k];
                    conta[y] = conta[k];
                }
                if (k == 9)
                {
                    nome[9] = null;
                    id[9] = 0;
                    conta[9] = 0;
                    agencia[9] = 0;
                }


            }
            i--;
        }
        public void preferencial()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|Digite o nome do cliente preferencial: |");
            Console.WriteLine("=========================================");

            String nn = Console.ReadLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("|Digite a conta do cliente preferencial: |");
            Console.WriteLine("==========================================");
            int ii = int.Parse(Console.ReadLine());

            Console.WriteLine("============================================");
            Console.WriteLine("|Digite a agência do cliente preferencial: |");
            Console.WriteLine("===========================================");
            int cc = int.Parse(Console.ReadLine());

            Console.WriteLine("==========================================");
            Console.WriteLine("|Digite a idade do cliente preferencial: |");
            Console.WriteLine("==========================================");
            int aa = int.Parse(Console.ReadLine());


            for (int y = 9; y > 0; y--)
            {
                int k = 0;
                if (y > 0)
                {
                    k = y - 1;
                    nome[y] = nome[k];
                    id[y] = id[k];
                    agencia[y] = agencia[k];
                    conta[y] = conta[k];
                }
                if (k == 0)
                {
                    nome[0] = nn;
                    id[0] = ii;
                    conta[0] = cc;
                    agencia[0] = aa;
                }


            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_de_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string leitura;

            Cliente c = new Cliente();

            do
            {
                //menu
                Console.WriteLine("===================================================");
                Console.WriteLine("|* * * * * * * * * * * *MENU* * * * * * * * * * * |");
                Console.WriteLine("|=================================================|");
                Console.WriteLine("|      Digite 'a' para adicionar os clientes      |");
                Console.WriteLine("|=================================================|");
                Console.WriteLine("|   Digite 'r' para atender o primeiro cliente    |");
                Console.WriteLine("|=================================================|");
                Console.WriteLine("|Digite 'p' para adicionar um cliente preferencial|");
                Console.WriteLine("|=================================================|");
                Console.WriteLine("|          Digite 'm' para mostrar a fila         |");
                Console.WriteLine("|=================================================|");
                Console.WriteLine("|               Digite 'q' para sair              |");
                Console.WriteLine("===================================================");


                leitura = Console.ReadLine();


                if (leitura.ToString().ToLower() == "a")
                {
                    c.addcliente();

                    Console.Clear();
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|O cliente foi adicionado com sucesso à fila!|");
                    Console.WriteLine("==============================================");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                 if (leitura.ToString().ToLower() == "m")
                {
                    c.mostrarfila();
                }
                else
                    if (leitura.ToString().ToLower() == "r")
                {
                    c.atendercliente();

                    Console.Clear();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("|O cliente da fila foi atendido com sucesso!|");
                    Console.WriteLine("=============================================");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                   if (leitura.ToString().ToLower() == "p")
                {
                    c.preferencial();

                    Console.Clear();
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("|O cliente preferencial foi adicionado com sucesso à fila|");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            } while (leitura.ToString().ToLower() != "q");
        }
    }
}

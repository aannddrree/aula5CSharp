using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMenu = true;

            string menu = "1 - Inserir\n2 - Consultar\n3 - Sair";

            while (isMenu)
            {
                Console.WriteLine(menu);
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());

                //Funções da nossa aplicação:
                switch (op)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        ListAll();
                        break;
                    case 3:
                        isMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            Console.ReadKey();
        }

        private static void Add()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            new ClienteService().Add(id, nome, telefone, salario, endereco);
        }

        private static void ListAll()
        {
            foreach (var item in new ClienteService().ListAll())
            {
                Console.WriteLine(item);
                Console.WriteLine("------------------------");
            }
        }
    }
}

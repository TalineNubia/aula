using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
       
        Agenda agenda = new Agenda();

        public void vaiCurinthians()
        {
            int op;

            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Listar todos");
                Console.WriteLine("3 - Buscar por nome");
                Console.WriteLine("Entre com uma opção: ");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo do sistema");
                        break;
                    case 1:
                        Console.Clear();
                        Contato contato = new Contato();                      

                        Console.WriteLine("Escreva o nome do contato: ");
                        contato.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe o numero do telefone: ");
                        contato.Telefone = Console.ReadLine();

                        agenda.Adicionar(contato);
                        break;

                    case 2:
                        {
                            Console.Clear();
                            
                            Console.WriteLine("*** Todos *** ");
                            Console.WriteLine("Nome\tFone");
                            foreach (Contato c in agenda.Buscar())
                            {
                                Console.WriteLine("{0}\t{1}", c.Nome, c.Telefone);
                            }
                            Console.WriteLine("Pressione uma tecla para retornar");
                            Console.ReadKey();
                        }

                        break;
                           case 3:
                            Console.Clear();
                           string nome1;
                           
                            Console.WriteLine("*** Buscar por nome *** ");

                            Console.WriteLine("Entre com  o nome: ");
                            nome1 = Console.ReadLine();
                            List<Contato> contatos = agenda.BuscarNome(nome1);
                            if (contatos.Count == 0)
                            {
                                Console.WriteLine("Nome nao encontrado.");
                            }
                            else
                            {
                                Console.WriteLine("Nome\tFone");
                                foreach (Contato c in contatos)
                                {
                                    Console.WriteLine("{0}\t{1}", c.Nome, c.Telefone);
                                }
                
                            }
                            Console.WriteLine("Pressione uma tecla para retornar");
                            Console.ReadKey();
                            break;
                        }
                

            } while (op != 0);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.vaiCurinthians();
        }

    }
}

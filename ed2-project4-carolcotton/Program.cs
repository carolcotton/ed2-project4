using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project4_carolcotton
{
    class Program
    {
        static void Main(string[] args)
        {
            Livros livros = new Livros();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Biblioteca Municipal\n" +
                "Menu\n" +                
                "1.Add Livro\n" +
                "2.Pesquisar Livro(s)\n" +
                "3.Pesquisar Livro(a)\n" +
                "4.Add Exemplar\n" +
                "5.Registrar Empréstimo\n" +
                "6.Registrar devolução\n" +
                "0.Sair\n");

                Console.Write("Insira a opção desejada : ");
                choice = Convert.ToInt32(Console.ReadLine());

                int isbn=0, tombo=0;
                string titulo="", autor="", editora="";

                switch (choice)
                {
                    case 0: break;
                    case 1:
                        
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insira o título do livro");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Insira o autor do livro");
                        autor = Console.ReadLine();
                        Console.WriteLine("Insira a editora do livro");
                        editora = Console.ReadLine();

                        livros.addLivro(new Livro(isbn, titulo, autor, editora));
                        Console.WriteLine("Livro inserido com sucesso!");
                        Console.ReadKey();                        
                        break;
                    case 2:                       
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------");
                        foreach (var l in livros.Acervo)
                        {
                            if (isbn == l.Isbn)
                            {
                                Console.WriteLine("Título do livro - " + l.Titulo);
                                Console.WriteLine("Autor do livro - " + l.Autor);
                                Console.WriteLine("Editora do livro - " + l.Editora);
                                Console.WriteLine("Quantidade total de exemplares : " + l.qtdeExemplares());
                                Console.WriteLine("Quantidade total de exemplares disponíveis : " + l.qtdeDisponiveis());
                                Console.WriteLine("Quantidade total de empréstimos : " + l.qtdeEmprestimos());
                                Console.WriteLine("Percentual de disponibilidade : " + l.percDisponibilidade());
                                Console.WriteLine("\n\nInsira qualquer tecla para continuar");
                                Console.ReadKey();
                            }
                        }                                               
                        break;
                    case 3: 
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------");
                        foreach (var l in livros.Acervo)
                        {
                            if (isbn == l.Isbn)
                            {
                                Console.WriteLine("Título do livro - " + l.Titulo);
                                Console.WriteLine("Autor do livro - " + l.Autor);
                                Console.WriteLine("Editora do livro - " + l.Editora);
                                Console.WriteLine("Quantidade total de exemplares : " + l.qtdeExemplares());
                                Console.WriteLine("Quantidade total de exemplares disponíveis : " + l.qtdeDisponiveis());
                                Console.WriteLine("Quantidade total de empréstimos : " + l.qtdeEmprestimos());
                                Console.WriteLine("Percentual de disponibilidade : " + l.percDisponibilidade());
                                Console.WriteLine("----------------------");
                                foreach (var e in l.Exemplares)
                                {
                                    Console.WriteLine("Tombo - " + e.Tombo);
                                    foreach(var em in e.Emprestimos)
                                    {
                                        Console.WriteLine("----------------------");
                                        Console.WriteLine("Empréstimo : " + em.DtEmprestimo);
                                        if(!e.disponivel())
                                        {
                                            Console.WriteLine("Devolução : " + em.DtDevolucao);
                                        }                                        
                                    }
                                }
                                Console.WriteLine("\n\nInsira qualquer tecla para continuar");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());

                        foreach (var l in livros.Acervo)
                        {
                            if (isbn == l.Isbn)
                            {
                                Console.WriteLine("Insira o tombo do livro");
                                tombo = Convert.ToInt32(Console.ReadLine());
                                l.addExemplar(new Exemplar(tombo));
                                Console.WriteLine("Tombo inserido com sucesso!");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        
                        foreach (var l in livros.Acervo)
                        {
                            if (isbn == l.Isbn)
                            {
                                Console.WriteLine("Insira o tombo do livro");
                                tombo = Convert.ToInt32(Console.ReadLine());
                                
                                foreach (var e in l.Exemplares)
                                {
                                    if (e.disponivel())
                                    {
                                        e.emprestar();
                                        Console.WriteLine("Livro emprestado com sucesso");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não é possível emprestar");
                                        Console.ReadKey();
                                    }  
                                }  
                            }
                        }
                            break;
                    case 6:
                        Console.WriteLine("Insira o ISBN do livro");
                        isbn = Convert.ToInt32(Console.ReadLine());

                        foreach (var l in livros.Acervo)
                        {
                            if (isbn == l.Isbn)
                            {
                                Console.WriteLine("Insira o tombo do livro");
                                tombo = Convert.ToInt32(Console.ReadLine());
                                foreach (var e in l.Exemplares)
                                {
                                    if (e.devolver())
                                    {
                                        e.devolver();
                                        Console.WriteLine("Livro devolvido com sucesso");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não é possível devolver");
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }

                        break;
                }
            } while (choice != 0);

        }        

    }
}
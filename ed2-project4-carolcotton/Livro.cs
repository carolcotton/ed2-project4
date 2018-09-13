using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project4_carolcotton
{
    class Livro
    {
        //variáveis
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        //propriedades
        public int Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Editora
        {
            get
            {
                return editora;
            }

            set
            {
                editora = value;
            }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
        }

        //Construtores
        public Livro (int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            exemplares = new List<Exemplar>();
        }
        public Livro(): this (0,"","","")
        {
        }

        //métodos
        public void addExemplar(Exemplar e)
        {
            exemplares.Add(e);
        }

        public int qtdeExemplares()
        {
            if(exemplares!=null)
            {
                return exemplares.Count;
            }
            return 0;
        }

        public int qtdeDisponiveis()
        {
           int qtd = 0;
           foreach(var e in exemplares)
           {
                if (e.disponivel())
                {
                    qtd++;
                }
           }
            return qtd;
        }

        public int qtdeEmprestimos()
        {
            int qtd = 0;
            foreach (var e in exemplares)
            {
                if (!e.disponivel())
                {
                    qtd++;
                }
            }
            return qtd;
        }

        public double percDisponibilidade()
        {
            return (Convert.ToDouble(qtdeExemplares()) * 100) / Convert.ToDouble(qtdeDisponiveis());
        }
    }
}

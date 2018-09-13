using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project4_carolcotton
{
    class Livros
    {
        //variáveis
        private List<Livro> acervo;

        //propriedades
        public List<Livro> Acervo
        {
            get { return acervo; }
        }

        //métodos
        public Livros()
        {
            acervo = new List<Livro>();
        }
        public void addLivro (Livro l)
        {
            acervo.Add(l);
        }
        public Livro Retorna(int isbn)
        {
            foreach (var l in acervo)
            {
                if (l.Isbn.Equals(isbn))
                {
                    return l;
                }
            }
            return null;
        }
    }
}

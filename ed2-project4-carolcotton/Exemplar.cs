using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project4_carolcotton
{
    class Exemplar
    {
        //variáveis
        private int tombo;
        private List<Emprestimo> emprestimos;

        //propriedades
        public int Tombo
        {
            get
            {
                return tombo;
            }

            set
            {
                tombo = value;
            }
        }
        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
        }

        //construtor
        public Exemplar(): this(0)
        {
        }
        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            emprestimos = new List<Emprestimo>();
        }

        //métodos
        public bool emprestar()
        {
            bool podeEmprestar = disponivel();
            if (podeEmprestar)
            {
                emprestimos.Add(new Emprestimo(DateTime.Now));
            }
            return podeEmprestar;
        }
        public bool devolver()
        {
            bool podeDevolver = disponivel();
            if (podeDevolver)
            {
                emprestimos[emprestimos.Count - 1].DtDevolucao = DateTime.Now;
            }
            return podeDevolver;

        }
        public bool disponivel()
        {
            bool disp = (emprestimos.Count == 0);
            if (!disp)
            {
                disp = emprestimos[emprestimos.Count - 1].DtDevolucao != null;
            }
            return disp;
            
        }
        public int qtdeEmprestimos()
        {
            return emprestimos.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project4_carolcotton
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo(): this(new DateTime(0))
        {
        }
        public Emprestimo(DateTime dtEmprestimo)
        {
            this.dtEmprestimo = dtEmprestimo;
        }

        public DateTime DtEmprestimo
        {
            get
            {
                return dtEmprestimo;
            }

            set
            {
                dtEmprestimo = value;
            }
        }

        public DateTime DtDevolucao
        {
            get
            {
                return dtDevolucao;
            }

            set
            {
                dtDevolucao = value;
            }
        }
    }
}

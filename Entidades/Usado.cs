using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExHerancaPolimorfismo.Entidades
{
    class Usado : Produto
    {
        public DateTime Fabricacao { get; set; }

        public Usado()
        {
        }

        public Usado(DateTime fabricacao, string nome, double preco) : base(nome, preco) 
        {
            Fabricacao = fabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " (Usado " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " )" + " (Data de fabricação: " + Fabricacao.ToString("dd/MM/yyyy") + " )";
        }


    }


}

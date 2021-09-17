using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExHerancaPolimorfismo.Entidades
{
    class Importado : Produto
    {
        public double Taxa { get; set; }

        public Importado()
        {
        }

        public Importado(double taxa, string nome, double preco) : base (nome, preco)
        {
            Taxa = taxa;
        }

        public double PrecoTotal()
        {
            return Preco + Taxa;
        }

        public override string Etiqueta()
        {
            return Nome + " $ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + "(Taxa: $ " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + " )";  
        }
    }
}

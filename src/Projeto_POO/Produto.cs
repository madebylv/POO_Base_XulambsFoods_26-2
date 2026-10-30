using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Produto
    {
        private double _preco;

        public virtual double CalcularValorFinal()
        {
            return _preco;
        }
    }
}

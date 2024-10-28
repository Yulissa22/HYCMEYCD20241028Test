using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HYCMEYCD20241028
{
    public class RaizCuadrada
    {
        public double Raiz(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numero), "El número no puede ser negativo.");
            }
            return Math.Sqrt(numero);
        }
    }
}





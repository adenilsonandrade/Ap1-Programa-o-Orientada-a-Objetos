using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public static class GeradorIds
    {
        private static int _contadorProd = 0;
        private static int _contadorClient = 0;

        public static int GerarIdCliente()
        {
            _contadorProd++;
            return _contadorProd;
        }
        public static int GerarIdProduto()
        {
            _contadorClient++;
            return _contadorClient;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolhendoAMusica
{
    class Musica2 : ICalculaMusica
    {
        public string Calcular(int num1, int num2)
        {
            int soma = num1 + num2;
            return (soma == 1) ? "P.Y.N.G.\n" : string.Empty;
        }
    }
}


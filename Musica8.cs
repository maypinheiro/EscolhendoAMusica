using System;
using System.Collections.Generic;
using System.Text;

namespace EscolhendoAMusica
{
    class Musica8 : ICalculaMusica
    {
        public string Calcular(int num1, int num2)
        {
            int soma = num1 + num2;
            return (soma == 7) ? "SALT\n" : string.Empty;
        }
    }
}
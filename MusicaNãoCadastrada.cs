using System;
using System.Collections.Generic;
using System.Text;

namespace EscolhendoAMusica
{
    class MusicaNãoCadastrada : ICalculaMusica
    {
        public string Calcular(int num1, int num2)
        {
            int soma = num1 + num2;
            return (soma <0 || soma > 10 ) ? "Música Não Cadastrada" : string.Empty;
        }
    }
}
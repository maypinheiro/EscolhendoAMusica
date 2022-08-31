using System;
using System.Collections.Generic;
using System.Text;

namespace EscolhendoAMusica
{
    public class Tela
    {
        public void Imprimir(string[] musicas)
        {
            foreach (string musica in musicas)
            {
                if (musica != string.Empty)
                    Console.WriteLine(musica);
            }
        }

        public int[] NovoValor()
        {
            Console.Write("Diguite dois numeros inteiros para escolher a Musica: ");

            string[] numeros = Console.ReadLine().Split(' ');
            return new int[] {
                int.Parse(numeros[0]),
                int.Parse(numeros[1])
            };
        }
    }

}


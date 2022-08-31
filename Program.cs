using System;

namespace EscolhendoAMusica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas Músicas deseja Escolher ?");
            var opcoes = int.Parse(Console.ReadLine());
            Tela tela = new Tela();
            var numeros = tela.NovoValor();

            var musica1 = new Musica1();
            var musica2 = new Musica2();
            var musica3 = new Musica3();
            var musica4 = new Musica4();
            var musica5 = new Musica5();
            var musica6 = new Musica6();
            var musica7 = new Musica7();
            var musica8 = new Musica8();
            var musica9 = new Musica9();
            var musica10 = new Musica10();
            var musica11 = new Musica11();
            var musicaNaoCadastrada = new MusicaNãoCadastrada();

            for (int i = 0; i < opcoes; i++)
            {
                tela.Imprimir(new string[] {

                    musica1.Calcular(numeros[0], numeros[1]),
                    musica2.Calcular(numeros[0], numeros[1]),
                    musica3.Calcular(numeros[0], numeros[1]),
                    musica4.Calcular(numeros[0], numeros[1]),
                    musica5.Calcular(numeros[0], numeros[1]),
                    musica6.Calcular(numeros[0], numeros[1]),
                    musica7.Calcular(numeros[0], numeros[1]),
                    musica8.Calcular(numeros[0], numeros[1]),
                    musica9.Calcular(numeros[0], numeros[1]),
                    musica10.Calcular(numeros[0], numeros[1]),
                    musica11.Calcular(numeros[0], numeros[1]),
                    musicaNaoCadastrada.Calcular(numeros[0], numeros[1]),

                });

                numeros = tela.NovoValor();
            }

        }
    }
}
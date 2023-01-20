using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Services
{
   public class ValidarEConverterEntradasDeUsuarios
    {
        public static int ConverterParaNumero()
        {
            string valorDigitado = Console.ReadLine();

            bool validador = int.TryParse(valorDigitado, out int numeroConvertido);

            if (!validador)
            {
                Console.WriteLine("O valor digitado é inválido. Digite novamente:");
                return ConverterParaNumero();

            }
            return numeroConvertido;
        }

        public static string ColetarNomeCompleto()
        {
            Console.WriteLine("Digite seu NOME COMPLETO:");
            string NomeCompleto = Console.ReadLine().ToUpper();
            var nomeCompletoConcatenado = NomeCompleto.Trim().Split(' ').Length;

            if (nomeCompletoConcatenado <= 1)
            {
                Console.WriteLine("É necessario Digitar seu SOBRENOME:");
                return ColetarNomeCompleto();
            }

            return NomeCompleto;
        }

        public static long ConverterParaLong()
        {
            string valorDigitado = Console.ReadLine();

            bool validador = long.TryParse(valorDigitado, out long numeroConvertido);

            ValidarTamanhoDoCpf(valorDigitado);


            if (!validador)
            {
                Console.WriteLine("O valor digitado é inválido. Digite novamente:");
                return ConverterParaLong();
            }


            return numeroConvertido;
        }
        private static void ValidarTamanhoDoCpf(string cpf)
        {
            int tamanhoDaString = cpf.Length;

            if (tamanhoDaString != 11)
            {
                Console.WriteLine("Você não digitou corretamente. Digite novamente:");
                ConverterParaLong();
            }


        }

        public static long ConverterParaLongCelular()
        {
            string valorDigitado = Console.ReadLine();

            bool validador = long.TryParse(valorDigitado, out long numeroConvertido);

            ValidarTamanhoDoTelefone(valorDigitado);


            if (!validador)
            {
                Console.WriteLine("O valor digitado é inválido. Digite novamente:");
                return ConverterParaLong();
            }


            return numeroConvertido;
        }
        private static void ValidarTamanhoDoTelefone(string telefone)
        {
            int tamanhoDaString = telefone.Length;

            if (tamanhoDaString != 11)
            {
                Console.WriteLine("Você não digitou corretamente. Digite novamente:");
                ConverterParaLongCelular();
            }


        }

        public static DateTime ConverterParaDateTime()
        {
            string valorDigitado = Console.ReadLine();

            bool validador = DateTime.TryParse(valorDigitado, out DateTime numeroConvertido);

            ValidarDateTime(valorDigitado);


            if (!validador)
            {
                Console.WriteLine("O valor digitado é inválido. Digite novamente:");
                return ConverterParaDateTime();
            }


            return numeroConvertido;
        }
        private static void ValidarDateTime(string telefone)
        {
            int tamanhoDaString = telefone.Length;

            if (tamanhoDaString < 8)
            {
                Console.WriteLine("Você não digitou corretamente. Digite novamente:");
                ConverterParaDateTime();
            }


        }
    }
}


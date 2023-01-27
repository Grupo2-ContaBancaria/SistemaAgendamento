using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaDeAgendamento.Metodos;
using sistemaDeAgendamento.Services;

namespace sistemaDeAgendamento.Services
{
    public class Seletor
    {
        public static List<string> Alternativas { get; set; } = new List<string>() { "Novo Agendamento", "Verificar Agendamentos Realizados", "Sair" };

        public static void MostrarAlternativas()
        {

            string descricaoMenu = "";


            for (int i = 1; i <= Alternativas.Count; i++)
            {
                descricaoMenu += $"({i}) {Alternativas[i - 1]} {Environment.NewLine}";
            }

            Console.WriteLine(descricaoMenu);

        }

        //METODO QUE VERIFICA SE A OPÇÃO DIGITADA NO MENU EXISTE NAS ALTERNATIVAS LISTADAS
        public static string EscolherMenu()
        {
            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            bool itemExiste = retorno <= Alternativas.Count;

            if (itemExiste)
            {
                Console.WriteLine($"Você escolheu o item {retorno}");
                return Alternativas[retorno - 1];
            }
            else
            {
                Console.WriteLine("Menu não existe, por favor escolha um número válido.");
                return EscolherMenu();
            }

        }
        public static void IniciarSessaoPosEscolha(string alternativaEscolhida, Agenda_Metodos agenda_Metodo)
        {
            switch (alternativaEscolhida)
            {
                case "Novo Agendamento":
                    agenda_Metodo.CriarAgendamento();
                    break;

                case "Verificar Agendamentos Realizados":
                    agenda_Metodo.ListarAgendamentos();
                    Console.ReadKey();
                    break;

                case "Sair":
                    Environment.Exit(0);
                    break;


                default:
                    break;
            }

        }

    }
}

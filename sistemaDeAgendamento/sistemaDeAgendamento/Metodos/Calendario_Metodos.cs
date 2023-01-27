using sistemaDeAgendamento.Entidades;
using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistemaDeAgendamento.Metodos
{
    public class Calendario_Metodos

    {
        public List<Entidades.Calendario> LstCalendarios { get; set; } = new();
        List<Entidades.Calendario> listaFiltrada;
        public Calendario_Metodos()
        {
            //leitura do arquivo
            string path = @"C:\Users\User\Desktop\ESTUDOS\LETSCODE_C#\agendamento\sistemaDeAgendamento\sistemaDeAgendamento\agenda.txt";
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    LstCalendarios.Add(new Entidades.Calendario(sr.ReadLine()));
                }


            }
        }
        public void ExibirCalendario(int idMedicoEscolhido)
        {
            var cabecalho = "Verifique agenda disponivel e indique o dia e horaraio que deseja agendar sua consulta: ";
            var corpo = "";

            listaFiltrada = LstCalendarios.FindAll(x => x.MedicoId == idMedicoEscolhido && x.Status == true);


            foreach (var item in listaFiltrada)
            {
                corpo += $"Código: {item.Id}---- Data:{item.Data} ---- Hora:{item.Hora} {Environment.NewLine}";
            }


            Console.WriteLine(cabecalho);
            Console.WriteLine(corpo);


        }

        public Calendario ColetarCalendario(int idMedico)
        {
            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

            var resultado = listaFiltrada.Where(x => x.Id == retorno).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirCalendario(idMedico);
                return ColetarCalendario(idMedico);
            }

            return resultado;
            //esse retorno aqui tenho que mandar pra agenda metodo
        }

        public  void ExcluirCalendarioAgendado(Calendario calendarioUsado)
        {
            var index = LstCalendarios.FindIndex(x => x.Id == calendarioUsado.Id);

            calendarioUsado.Status = false;

            LstCalendarios[index] = calendarioUsado;
        }


    }
}

        
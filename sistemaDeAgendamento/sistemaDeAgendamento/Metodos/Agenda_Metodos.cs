
using sistemaDeAgendamento.Entidades;
using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Agenda_Metodos
    {

        List<Agenda> LstAgenda = new();

        FormaPgto_Metodo usuario_pgto = new Metodos.FormaPgto_Metodo();

        Procedimentos_Metodos usuario_procedimento = new Metodos.Procedimentos_Metodos();

        Medicos_Metodo usuario_medico = new Medicos_Metodo();

        Especialidade_Metodo usuario_especialidade = new Especialidade_Metodo();

        Calendario_Metodos usuario_calendario = new Calendario_Metodos();

        //cadastra novo Usuario
        public void CriarAgendamento()
        {

            int id_formaPgto = usuario_pgto.ExibirFormaPgto();

            int escolhaProcedimento = usuario_procedimento.ExibirProcedimento();

            usuario_especialidade.Filtro(escolhaProcedimento, id_formaPgto == 1, id_formaPgto == 2);
            int id_Especialidade = usuario_especialidade.ColetarEspecialidade();


            usuario_medico.Filtro(id_Especialidade);
            int id_Medico = usuario_medico.ColetarNomeMedico();


            usuario_calendario.ExibirCalendario(id_Medico);
            var diaEHoraEscolhido = usuario_calendario.ColetarCalendario(id_Medico);

            Agenda novoAgendamento = new Agenda();
            novoAgendamento.Id = new Random().Next();
            novoAgendamento.Id_FormaPgto = id_formaPgto;
            novoAgendamento.Id_procedimento = escolhaProcedimento;
            novoAgendamento.Id_Especialidade = id_Especialidade;
            novoAgendamento.Id_Medico = id_Medico;
            novoAgendamento.Id_Calendario = diaEHoraEscolhido.Id;

            Gravar(novoAgendamento);

            var cabecalho = "Agendamento Realizado com Sucesso!!!";
            Console.WriteLine(cabecalho);
            Exibir(novoAgendamento);
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Inicial");
            Console.ReadKey();
        }

        public void Gravar(Agenda novoAgendamento)
        {
            LstAgenda.Add(novoAgendamento);

        }

        public void Exibir(Agenda agenda)
        {
            string nomeFormaPgto = usuario_pgto.LstFormaPgto.Find(x => x.Id == agenda.Id_FormaPgto).Tipo;
            string nomeProcedimento = usuario_procedimento.LstProcedimentos.Find(x => x.Id == agenda.Id_procedimento).Tipo;
            string nomeEspecialidade = usuario_especialidade.LstEspecialidades.Find(x => x.Id == agenda.Id_Especialidade).Nome;
            string nomeMedico = usuario_medico.LstMedicos.Find(x => x.Id == agenda.Id_Medico).Nome;
            var diaConsulta = usuario_calendario.LstCalendarios.Find(x => x.Id == agenda.Id_Calendario).Data;
            var horaConsulta = usuario_calendario.LstCalendarios.Find(x => x.Id == agenda.Id_Calendario).Hora;
            var corpo = "";

            corpo += $"\nDetalhes do agendamento\nProcedimento: {nomeProcedimento}\n" +
                $"Especialidade:{nomeEspecialidade} ----  Medico:{nomeMedico}\n" +
                $"Data :{diaConsulta} -- Horario:{horaConsulta}\n";


            Console.WriteLine(corpo);


        }

        public void ListarAgendamentos()
        {
            foreach (var item in LstAgenda)
            {
                Exibir(item);
            }
                        
        }

      

    }
}

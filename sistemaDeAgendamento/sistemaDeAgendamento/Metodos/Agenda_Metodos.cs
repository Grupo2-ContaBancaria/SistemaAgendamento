using sistemaDeAgendamento.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Agenda_Metodos
    {
        public List<Classes.Agenda> LstAgenda { get; set; } = new();

        public void Cadastrar(Classes.Agenda agenda)
        {
            LstAgenda.Add(agenda);
        }

    }
}

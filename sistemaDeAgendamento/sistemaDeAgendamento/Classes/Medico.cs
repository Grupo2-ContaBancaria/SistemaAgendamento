using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Classes
{
    public class Medico: Base
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public bool Status { get; set; }

        // cada médico tem sua especialidade
        public string especialidade { get; set; }

        //dados do médico
        public string nomeMedico { get; set; }
        public int CRM { get; set; }

    }
}

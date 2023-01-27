using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Entidades
{
    public class Medicos : Base
    {

        public int Crm { get; set; }
        public string Nome { get; set; }
        public int Id_Especialidade { get; set; }

    }
}

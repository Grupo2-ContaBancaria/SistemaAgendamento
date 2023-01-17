using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Classes
{
    public class Agenda : Base
    {
        //Eu Monica vou criar a classe agenda - inicialemnte vou definir as propriedades e o tipo de dado de cada propriedade
        public string Nome_Usuario { get; set; }
        public string Nome_Medico { get; set; }
        public string Nome_Especialidade { get; set; }
        public string Nome_Procedimento { get; set; }
        public string Nome_FormaPgto { get; set; }
        public DateTime Data_Marcada { get; set; }
        public DateTime Hora_Marcada { get; set; }
    }
}

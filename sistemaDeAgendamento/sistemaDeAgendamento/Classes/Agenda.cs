using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Classes
{
    public class Agenda:Base
    {
        //Eu Monica vou criar a classe agenda - inicialemnte vou definir as propriedades e o tipo de dado de cada propriedade
        public string Especialidade { get; set; } = "";
        public string NomeMedico { get; set; }
    }
}

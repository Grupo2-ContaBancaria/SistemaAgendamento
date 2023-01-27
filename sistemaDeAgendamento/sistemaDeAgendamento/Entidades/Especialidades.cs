using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Entidades
{
    public class Especialidades : Base
    {
        //Eu Camila vou criar a classe Especialidades - inicialmente vou definir as propriedades e o tipo de dado de cada propriedade
        public string Nome { get; set; }
        public int ProcedimentoId { get; set; }
        public bool PgtoConvenio { get; set; }
        public bool PgtoParticular { get; set; }
    }
}
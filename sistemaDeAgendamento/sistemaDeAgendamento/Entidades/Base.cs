using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Entidades
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public bool Status { get; set; } = true;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Especialidade
    {
        public List<Classes.Especialidades> LstEspecialidades { get; set; } = new();

        public Especialidade()
        {   
            //
            LstEspecialidades.Add(new Classes.Especialidades() { Id = 1, Nome = "Cardiologia" });
            LstEspecialidades.Add(new Classes.Especialidades() { Id = 2, Nome = "Pediatria" });
        }
    }
}

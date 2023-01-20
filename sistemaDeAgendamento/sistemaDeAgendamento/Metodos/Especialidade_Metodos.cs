using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Especialidade_Metodos
    {
        public List<Classes.Especialidades> LstEspecialidades { get; set; } = new();

        public Especialidade_Metodos()
        {   
            //
            LstEspecialidades.Add(new Classes.Especialidades() { Id = 1, Nome = "Cardiologia" });
            LstEspecialidades.Add(new Classes.Especialidades() { Id = 2, Nome = "Pediatria" });
        }
    }
}

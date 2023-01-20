using sistemaDeAgendamento.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Interface
{
    public interface IPaciente
    {
        Paciente Cadastrar();
        void ExibirMensagemBoasVindas(string Nome);
    }
}

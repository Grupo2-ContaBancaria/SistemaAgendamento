using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaDeAgendamento.Metodos;
using sistemaDeAgendamento.Interface;
using sistemaDeAgendamento.Classes;

namespace sistemaDeAgendamento.Services
{
    public class NovoPaciente
    {
        private readonly IPaciente? _ipaciente;
        public NovoPaciente()
        {
            _ipaciente = new Paciente_Metodos();
        }
        public Paciente IniciarNovoPerfil()
        {
            var usuario = _ipaciente.Cadastrar();
            _ipaciente.ExibirMensagemBoasVindas(usuario.Nome);
            return usuario;
        }
    }
}

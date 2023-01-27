using sistemaDeAgendamento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Interface
{
    public interface IUsuario
    {
        Usuario Cadastrar();
        void ExibirMensagemBoasVindas(string Nome);
        Usuario LogarUsuario();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaDeAgendamento.Metodos;
using sistemaDeAgendamento.Interface;

using sistemaDeAgendamento.Entidades;

namespace sistemaDeAgendamento.Services
{
    public class NovoUsuario
    {

        private readonly IUsuario? _iusuario;

        public NovoUsuario(Usuario_Metodo usuario_Metodo)
        {
            _iusuario = usuario_Metodo;
        }
        public Usuario IniciarNovoPerfil()
        {
            var usuarioCriado = _iusuario.Cadastrar();
            _iusuario.ExibirMensagemBoasVindas(usuarioCriado.Nome);
            return usuarioCriado;
        }

    }
}

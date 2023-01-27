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
    public class UsuarioService
    {
        //Uso da Interface para cadastrar e exibir msg de boas vindas
        private readonly IUsuario? _iusuario;

        public UsuarioService(IUsuario iusuario)
        {
            _iusuario = iusuario;
        }
        public Usuario IniciarNovoPerfil()
        {
            var usuarioCriado = _iusuario.Cadastrar();
            _iusuario.ExibirMensagemBoasVindas(usuarioCriado.Nome);
            return usuarioCriado;
        }

        public Usuario LogarUsuario()
        {
            var usuarioExistente = _iusuario.LogarUsuario();
            _iusuario.ExibirMensagemBoasVindas(usuarioExistente.Nome);
            return usuarioExistente;
            ;
        }

    }
}

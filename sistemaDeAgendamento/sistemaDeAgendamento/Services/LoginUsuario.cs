﻿using sistemaDeAgendamento.Entidades;
using sistemaDeAgendamento.Interface;
using sistemaDeAgendamento.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Services
{
    public class LoginUsuario
    {


        private readonly IUsuario? _iusuario;
        public LoginUsuario()
        {
            _iusuario = new Usuario_Metodo();
        }
        //acoplamento

        public Usuario LogarUsuario()
        {
            var usuarioExistente = _iusuario.LogarUsuario();
            _iusuario.ExibirMensagemBoasVindas(usuarioExistente.Nome);
            return usuarioExistente;
            ;
        }

    }
}
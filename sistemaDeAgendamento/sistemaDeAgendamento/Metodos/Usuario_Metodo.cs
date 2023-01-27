using sistemaDeAgendamento.Interface;
using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaDeAgendamento.Entidades;

namespace sistemaDeAgendamento.Metodos
{
    public class Usuario_Metodo : IUsuario
    {
        public Usuario Cadastrar()
        {

            var Nome = Services.ValidarEConverterEntradaDeUsuario.ColetarNomeCompleto();

            Console.WriteLine("Digite seu CPF:");
            var CPF = Services.ValidarEConverterEntradaDeUsuario.ConverterParaLong();

            Console.WriteLine("Digite seu numero de Telefone Celular com DDD: ");
            var Celular = Services.ValidarEConverterEntradaDeUsuario.ConverterParaLongCelular();

           
            Console.WriteLine("Informe sua Data de Nascimento: (dia/mês/ano):");
            var Data_Nascimento = Services.ValidarEConverterEntradaDeUsuario.ConverterParaDateTime();
            

            return new Usuario(Nome, CPF, Data_Nascimento, Celular);


        }

        public void ExibirMensagemBoasVindas(string Nome)
        {
            string mensagem = $"Olá, {Nome.Split(" ")[0]}!!\nSeja Bem Vindo (a), vamos iniciar seu Agendamento?\n" +
                $"\n" +
                $"O que deseja fazer?\n" +
                $" ";
            Services.ConfiguraLayout.ClearLayout();
            Services.ConfiguraLayout.LayoutDoConsole();

            Console.WriteLine(mensagem);
        }

        public Usuario LogarUsuario()
        {
            Console.WriteLine("Digite seu CPF:");
            var CPF = Services.ValidarEConverterEntradaDeUsuario.ConverterParaLong();


            Console.WriteLine("Digite sua senha:");
            var senha = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();


            return new Usuario("Michael Oliveira", CPF, new DateTime(1987, 01, 12), 3196307731, senha);

        }


    }
}

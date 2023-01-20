using sistemaDeAgendamento.Interface;
using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaDeAgendamento.Classes;

namespace sistemaDeAgendamento.Metodos
{
    public class Paciente_Metodos:IPaciente
    {
        public Paciente Cadastrar()
        {
            var Nome = Services.ValidarEConverterEntradasDeUsuarios.ColetarNomeCompleto();

            Console.WriteLine("Digite seu CPF:");
            var CPF = Services.ValidarEConverterEntradasDeUsuarios.ConverterParaLong();

            Console.WriteLine("Digite seu numero de Telefone Celular: ");
            var Celular = Services.ValidarEConverterEntradasDeUsuarios.ConverterParaLongCelular();

            Console.WriteLine("informe seu genero (1) Feminino (2) Masculino:");
            var Sexo = Services.ValidarEConverterEntradasDeUsuarios.ConverterParaNumero();

            Console.WriteLine("Informe sua Data de Nascimento: (dia/mês/ano):");
            var Data_Nascimento = Services.ValidarEConverterEntradasDeUsuarios.ConverterParaDateTime();

            return new Paciente();

        }

        public void ExibirMensagemBoasVindas(string Nome)
        {
            string mensagem = $"Olá, {Nome.Split(" ")[0]}!!\nSeja Bem Vindo (a), vamos iniciar seu Agendamento?\n" +
                $"\n" +
                $"O que deseja fazer?\n" +
                $" ";
            Services.ConfiguracaoLayout.ClearLayout();
            Services.ConfiguracaoLayout.LayoutDoConsole();
            

            Console.WriteLine(mensagem);
        }
    }
}

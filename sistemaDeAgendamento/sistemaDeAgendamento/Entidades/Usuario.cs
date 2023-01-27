using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Entidades
{
    public class Usuario : Base
    {
        public string Nome { get; protected set; }
        public long CPF { get; protected set; }
        public DateTime Data_Nascimento { get; protected set; }
        public long Celular { get; protected set; }
        

        public Usuario(string nome, long cpf, DateTime data_nascimento, long celular)
        {
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_nascimento;
            Celular = celular;
            Id = new Random().Next();

        }
        public Usuario(string nome, long cpf, DateTime data_nascimento, long celular, int senha)
        {
            Nome = nome;
            CPF = cpf;
            Data_Nascimento = data_nascimento;
            Celular = celular;
            Id=  new Random().Next();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Classes
{
    //Eu Rodrigo-Freire vou criar a Class Paciente
    public class Paciente
    {
        //Definindo as propriedades para a Class
        public long cpf { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        //criando método para validar cpf (ainda ta bem no começo, mas vou conseguir desenvolver! oremos! kkkk)
        public bool checkCpf(string cpf)
        {
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF invalido!" +
                    "\nPor favor, digite novamente");
                return false;
            }
            return true;
        }
        public string Nome { get; set; }
    }
}

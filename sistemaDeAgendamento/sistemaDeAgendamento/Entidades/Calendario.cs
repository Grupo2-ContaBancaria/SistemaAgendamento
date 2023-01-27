using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Entidades
{
    public class Calendario : Base
    {
        //Esta classe recebe uma importacao de arquivo para carregar suas informações
        public int MedicoId { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
       
        public Calendario()
        {

        }
        public Calendario(string csvDicionario)
        {
            string[] vect = csvDicionario.Split(',');
            Id = int.Parse(vect[0]);
            MedicoId = int.Parse(vect[1]);
            Data = vect[2];
            Hora = vect[3];
            //Situacao = vect[4];

        }
    }
}

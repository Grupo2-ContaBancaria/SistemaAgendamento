using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Calendario_Metodos
    {
        public List<Classes.Calendario> LstCalendarios { get; set; }

        public Calendario_Metodos()
        {
            var hora = 8;
            var data = 1;
            var random = new Random();

            // o 15 representa a quantidade de medicos cadastrados, preciso alterar quandoo tiver a qdt exata
            for (int i = 1; i <= 15; i++)
            {
                if (hora > 16)
                {
                    hora = 8;
                    data++;
                }

                LstCalendarios.Add(
                    new Classes.Calendario()
                    {
                        Id = i,
                        Data = DateTime.Now.AddDays(data).ToString("dd/MM/YYYY"),
                        Hora = new DateTime(2023, 12, 1, hora, 0, 0).AddHours(i).ToString("HH:mm"),
                        Situacao = "l",
                        MedicoId = random.Next(1, 42)
                    });

                hora++;

            }
        }
    }
}
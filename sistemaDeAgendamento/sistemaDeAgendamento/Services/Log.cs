using sistemaDeAgendamento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Services
{
    public class Log
    {
        public static void InformacaoLog(object obj)
        {
            //Uso do Reflection para exibir os dados da classe Usuario
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Dados do " + tipo.Name);
            builder.AppendLine("Data de cadastro: " + DateTime.Now);
            foreach (var prop in tipo.GetProperties())
            {
                
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }
            ImprimeLog(builder.ToString());
        }

        public static void ImprimeLog(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void LogarUsandoReflection(Object obj)
        {
            Log.InformacaoLog(obj);
            
        }
    }

}
    

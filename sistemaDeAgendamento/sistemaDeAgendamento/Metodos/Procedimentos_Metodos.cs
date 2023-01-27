using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Procedimentos_Metodos
    {

        public List<Entidades.Procedimentos> LstProcedimentos { get; set; } = new();
        public Procedimentos_Metodos()
        {
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 1, Tipo = "Consulta", Valor = 100.00 });
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 2, Tipo = "Exame", Valor = 200.00 });
            LstProcedimentos.Add(new Entidades.Procedimentos() { Id = 3, Tipo = "Cirurgia", Valor = 1000.00 });
        }
        public int ExibirProcedimento()
        {
            Services.ConfiguraLayout.ClearLayout();
            Services.ConfiguraLayout.LayoutDoConsole();

            string descricaoMenu = "";
            Console.WriteLine($"Indique qual será o procedimento:\n");

            foreach (var item in LstProcedimentos)
            {
                Console.WriteLine(descricaoMenu = $"({item.Id}) --- {item.Tipo}");
            }


            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            ColetarProcedimento(retorno);
            return retorno;
        }
        public void ColetarProcedimento(int id)
        {
            int retorno = 0;
            var resultado = LstProcedimentos.Where(x => x.Id == id).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirProcedimento();
            }



        }
    }
}

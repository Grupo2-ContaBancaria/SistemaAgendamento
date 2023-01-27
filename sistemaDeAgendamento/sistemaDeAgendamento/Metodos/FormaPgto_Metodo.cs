using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class FormaPgto_Metodo
    {
        public List<Entidades.FormaPgto> LstFormaPgto { get; set; } = new();
        public FormaPgto_Metodo()
        {
            LstFormaPgto.Add(new Entidades.FormaPgto() { Id = 1, Tipo = "Convênio" });
            LstFormaPgto.Add(new Entidades.FormaPgto() { Id = 2, Tipo = "Particular" });
        }

        public int ExibirFormaPgto()
        {
            string descricaoMenu = "";

            Console.WriteLine($"Indique qual será a Forma de Pagamento:\n");
            foreach (var item in LstFormaPgto)
            {
                descricaoMenu = $"({item.Id}) --- {item.Tipo}";
                Console.WriteLine(descricaoMenu);
            }


            int retorno = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();
            ColetarFormaPgto(retorno);

            return retorno;
        }
        public void ColetarFormaPgto(int id)
        {

            var resultado = LstFormaPgto.Where(x => x.Id == id).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirFormaPgto();
            }


        }
    }
}

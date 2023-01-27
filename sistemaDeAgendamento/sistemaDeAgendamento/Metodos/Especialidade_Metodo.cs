using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Especialidade_Metodo
    {
        public List<Entidades.Especialidades> LstEspecialidades { get; set; } = new();

        public Especialidade_Metodo()
        {
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 1, PgtoConvenio = false, PgtoParticular = true, Nome = "Acupuntura", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 2, PgtoConvenio = true, PgtoParticular = true, Nome = "Cardiologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 3, PgtoConvenio = true, PgtoParticular = true, Nome = "Dermatologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 4, PgtoConvenio = true, PgtoParticular = true, Nome = "Ginecologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 5, PgtoConvenio = true, PgtoParticular = true, Nome = "Infectologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 6, PgtoConvenio = true, PgtoParticular = true, Nome = "Neurologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 7, PgtoConvenio = true, PgtoParticular = true, Nome = "Otorrinolaringolista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 8, PgtoConvenio = true, PgtoParticular = true, Nome = "Oftalmologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 9, PgtoConvenio = true, PgtoParticular = true, Nome = "Ortopedista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 10, PgtoConvenio = true, PgtoParticular = true, Nome = "Pediatra", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 11, PgtoConvenio = true, PgtoParticular = true, Nome = "Pneumologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 12, PgtoConvenio = true, PgtoParticular = true, Nome = "Reumatologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 13, PgtoConvenio = true, PgtoParticular = true, Nome = "Urologista", ProcedimentoId = 1 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 14, PgtoConvenio = true, PgtoParticular = true, Nome = "Cirurgia Geral", ProcedimentoId = 3 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 15, PgtoConvenio = true, PgtoParticular = true, Nome = "Cirurgia Cardiovascular", ProcedimentoId = 3 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 16, PgtoConvenio = true, PgtoParticular = true, Nome = "Cirurgia Pediátrica", ProcedimentoId = 3 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 17, PgtoConvenio = true, PgtoParticular = true, Nome = "Cirurgia Vascular", ProcedimentoId = 3 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 18, PgtoConvenio = false, PgtoParticular = true, Nome = "Cirurgia Plástica", ProcedimentoId = 3 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 19, PgtoConvenio = true, PgtoParticular = true, Nome = "Patologia clínica/medicina laboratorial", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 20, PgtoConvenio = true, PgtoParticular = true, Nome = "Eletrocardiograma", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 21, PgtoConvenio = true, PgtoParticular = true, Nome = "Ultrassom", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 22, PgtoConvenio = true, PgtoParticular = true, Nome = "Ressonância", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 23, PgtoConvenio = true, PgtoParticular = true, Nome = "Raio X", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 24, PgtoConvenio = true, PgtoParticular = true, Nome = "Tomografia", ProcedimentoId = 2 });
            LstEspecialidades.Add(new Entidades.Especialidades() { Id = 25, PgtoConvenio = true, PgtoParticular = true, Nome = "Endoscopia", ProcedimentoId = 2 });

        }
        public void Filtro(int id_procedimento, bool convenio, bool particular)
        {
            //onde x é a classe. classe tem a propriedade id que e usada para localizar o procedimento
            var filtroEspecialidades = LstEspecialidades.Where(x => x.ProcedimentoId == id_procedimento && (x.PgtoConvenio == convenio || x.PgtoParticular == particular)).ToList();

            ExibirEspecialidade(filtroEspecialidades);
        }
        public void ExibirEspecialidade(List<Entidades.Especialidades> lstFiltrada)
        {
            string descricaoMenu = "";
            Console.WriteLine("Especialidades:\n");
            foreach (var item in lstFiltrada)
            {
                descricaoMenu = $"({item.Id}) --- {item.Nome}";
                Console.WriteLine(descricaoMenu);
            }
        }
        public int ColetarEspecialidade()
        {
            Console.WriteLine("Escolha uma especialidade: ");
            int id = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

            var resultado = LstEspecialidades.Where(x => x.Id == id).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ColetarEspecialidade();
                //ExibirEspecialidade();
            }
            return id;
            //esse retorno aqui tenho que mandar pra agenda metodo

        }
    }
}

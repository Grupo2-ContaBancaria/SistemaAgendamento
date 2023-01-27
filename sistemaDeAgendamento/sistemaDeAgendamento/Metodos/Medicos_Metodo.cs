using sistemaDeAgendamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAgendamento.Metodos
{
    public class Medicos_Metodo
    {
        public List<Entidades.Medicos> LstMedicos { get; set; } = new();
        List<Entidades.Medicos> filtroMedico;
        public Medicos_Metodo()
        {

            LstMedicos.Add(new Entidades.Medicos() { Id = 1, Id_Especialidade = 1, Nome = "João Antônio Nobrega", Crm = 0001 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 2, Id_Especialidade = 2, Nome = "Ana Gomes", Crm = 0002 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 3, Id_Especialidade = 3, Nome = "Francisco Manoel Nobrega", Crm = 0003 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 4, Id_Especialidade = 4, Nome = "Ana Beatriz Dias", Crm = 0005 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 5, Id_Especialidade = 5, Nome = "Luana Oliveira", Crm = 0006 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 6, Id_Especialidade = 6, Nome = "Miguel Martins", Crm = 0007 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 7, Id_Especialidade = 7, Nome = "Roberta Mendes", Crm = 0008 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 8, Id_Especialidade = 8, Nome = "Eduarda Oliveira", Crm = 0009 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 9, Id_Especialidade = 9, Nome = "Yasmim Albuquerque", Crm = 0010 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 10, Id_Especialidade = 10, Nome = "Samuel Coimbra", Crm = 0011 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 11, Id_Especialidade = 11, Nome = "Leticia Almeida Castro", Crm = 0012 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 12, Id_Especialidade = 12, Nome = "Nicolas Veiga", Crm = 0013 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 13, Id_Especialidade = 13, Nome = "Manuel Fonseca", Crm = 0014 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 14, Id_Especialidade = 14, Nome = "Arthur Henrique Mendes Costa", Crm = 0015 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 15, Id_Especialidade = 15, Nome = "Maria Paula Eduarda Oliveira Silva", Crm = 0016 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 16, Id_Especialidade = 16, Nome = "Antono Miguel Martins", Crm = 0017 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 17, Id_Especialidade = 17, Nome = "Roberta Maria Mendes", Crm = 0018 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 18, Id_Especialidade = 18, Nome = "Elis Eduarda Oliveira", Crm = 0019 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 19, Id_Especialidade = 19, Nome = "Yasmim Mendes Albuquerque", Crm = 0020 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 20, Id_Especialidade = 20, Nome = "Samuel Pereira Coimbra", Crm = 0021 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 21, Id_Especialidade = 21, Nome = "Guilherme Luz  Castro", Crm = 0022 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 22, Id_Especialidade = 22, Nome = "Bernardo Kauã Veiga", Crm = 0023 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 23, Id_Especialidade = 23, Nome = "Giovany Mendes Albuquerque", Crm = 0024 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 24, Id_Especialidade = 24, Nome = "Rafaella Pereira Coimbra", Crm = 0025 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 25, Id_Especialidade = 25, Nome = "Leticia Luz  Castro", Crm = 0026 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 26, Id_Especialidade = 16, Nome = "Kauã Santos", Crm = 0027 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 27, Id_Especialidade = 1, Nome = "Luiza Antony", Crm = 0028 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 28, Id_Especialidade = 2, Nome = "Samuel Pereira Coimbra", Crm = 0029 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 29, Id_Especialidade = 3, Nome = "Liz Silva", Crm = 0030 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 30, Id_Especialidade = 4, Nome = "Valentina Cardoso", Crm = 0031 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 31, Id_Especialidade = 5, Nome = "Simone Lemon", Crm = 0032 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 32, Id_Especialidade = 6, Nome = "Pedro Paulo Sobrinho", Crm = 0033 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 33, Id_Especialidade = 7, Nome = "Enfermaria", Crm = 0034 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 34, Id_Especialidade = 14, Nome = "Tanaka Kin", Crm = 0035 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 35, Id_Especialidade = 4, Nome = "Jim Kiro San", Crm = 0036 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 36, Id_Especialidade = 5, Nome = "Magda Feliz", Crm = 0037 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 37, Id_Especialidade = 2, Nome = "Joana Garcia", Crm = 0038 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 38, Id_Especialidade = 6, Nome = "Eliza José Gouveia", Crm = 0032 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 39, Id_Especialidade = 8, Nome = "Pedro Henrique Paulo Junior", Crm = 0039 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 40, Id_Especialidade = 10, Nome = "Maria Elizabeth Hunter", Crm = 0040 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 41, Id_Especialidade = 11, Nome = "Meg Grinn", Crm = 0041 });
            LstMedicos.Add(new Entidades.Medicos() { Id = 42, Id_Especialidade = 12, Nome = "Sushiro San", Crm = 0042 });

        }
        public void Filtro(int id_especialidade)
        {
           filtroMedico = LstMedicos.Where(x => x.Id_Especialidade == id_especialidade).ToList();


            ExibirEspecialidade(filtroMedico);
        }
        public void ExibirEspecialidade(List<Entidades.Medicos> lstFiltrada)
        {
            string descricaoMenu = "";
            Console.WriteLine("Medicos:\n");
            foreach (var item in lstFiltrada)
            {
                descricaoMenu = $"({item.Id}) --- {item.Nome}";
                Console.WriteLine(descricaoMenu);
            }
        }
        public int ColetarNomeMedico()
        {
            Console.WriteLine("Escolha o médico ");
            int id = ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

            var resultado = filtroMedico.Where(x => x.Id == id).FirstOrDefault();

            if (resultado == null)
            {
                Console.WriteLine("Opção Inválida!");
                ExibirEspecialidade(filtroMedico);
                return ColetarNomeMedico();

            }
            return id;
            //esse retorno aqui tenho que mandar pra agenda metodo

        }
    }
}

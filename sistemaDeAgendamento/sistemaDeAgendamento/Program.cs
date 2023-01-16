using sistemaDeAgendamento.Metodos;

namespace sistemaDeAgendamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var cAg = new Classes.Agenda();
            var ag = new Agenda();
            var esp = new Especialidade();


            //foreach (var item in ag.LstAgenda)
            //{
            //    Console.WriteLine($"Agenda: {item.DataCriacao} - Numero Agendamento: {item.Id}");
            //}



            //Aqui será feito o menu, apresentando os itens da lista criada na classe Metodos.Especialidade
            Console.WriteLine($"Ecolha a especialidade");
            foreach (var item in esp.LstEspecialidades)
            {
                Console.WriteLine($"({item.Id}) - {item.Nome}");
            }

            //Aqui, pede para escolher um NÚMERO do menu que representa o ID da especialidade
            var escolhaEsp = Console.ReadLine();

            //Aqui, faz o filtro na listade de especialidades criada em Metodos.Especialidade pelo número digitado pelo usuário "var escolhaEsp = Console.ReadLine();"
            var especialidadeEscolhida = esp.LstEspecialidades.Where(x => x.Id == Convert.ToInt32(escolhaEsp)).FirstOrDefault();


            //Após especialidade ser escolhida, filtrar os médicos que possuem esta especialidade




            //ag.Cadastrar(cAg);
            
            //cAg.Especialidade = especialidadeEscolhida.Nome;

            //Console.WriteLine($"Esp: {especialidadeEscolhida.Nome} - Numero Agendamento: {especialidadeEscolhida.Id}");


        }
    }
}
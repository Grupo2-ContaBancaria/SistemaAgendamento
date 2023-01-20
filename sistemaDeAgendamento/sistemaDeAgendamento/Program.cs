using sistemaDeAgendamento.Metodos;

namespace sistemaDeAgendamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services.ConfiguracaoLayout.LayoutDoConsole();

            try
            {
                int retorno = 0;

                do
                {
                    Console.WriteLine("Seja Bem Vindo(a):\nO que deseja fazer:\n(1)Criar Perfil\n(2)Acessar Perfil ");


                    retorno = Services.ValidarEConverterEntradasDeUsuarios.ConverterParaNumero();

                } while (retorno < 1 || retorno > 2);

                if (retorno == 1)
                {
                    var usuario = new Services.NovoPaciente();
                    usuario.IniciarNovoPerfil();

                    Services.MenuInicial.MostrarAlternativas();


                }
                else if (retorno == 2)
                {

                }


            }
            catch (Exception ex)
            {
                Services.ConfiguracaoLayout.ClearLayout();
                Console.WriteLine(ex.Message);

            }

            //Console.WriteLine("Hello, World!");

            //var cAg = new Classes.Agenda();
            //var ag = new Agenda();
            //var esp = new Especialidade();


            ////foreach (var item in ag.LstAgenda)
            ////{
            ////    Console.WriteLine($"Agenda: {item.DataCriacao} - Numero Agendamento: {item.Id}");
            ////}



            ////Aqui será feito o menu, apresentando os itens da lista criada na classe Metodos.Especialidade
            //Console.WriteLine($"Ecolha a especialidade");
            //foreach (var item in esp.LstEspecialidades)
            //{
            //    Console.WriteLine($"({item.Id}) - {item.Nome}");
            //}

            ////Aqui, pede para escolher um NÚMERO do menu que representa o ID da especialidade
            //var escolhaEsp = Console.ReadLine();

            ////Aqui, faz o filtro na listade de especialidades criada em Metodos.Especialidade pelo número digitado pelo usuário "var escolhaEsp = Console.ReadLine();"
            //var especialidadeEscolhida = esp.LstEspecialidades.Where(x => x.Id == Convert.ToInt32(escolhaEsp)).FirstOrDefault();


            ////Após especialidade ser escolhida, filtrar os médicos que possuem esta especialidade




            //ag.Cadastrar(cAg);

            //cAg.Especialidade = especialidadeEscolhida.Nome;

            //Console.WriteLine($"Esp: {especialidadeEscolhida.Nome} - Numero Agendamento: {especialidadeEscolhida.Id}");


        }
    }
}
using sistemaDeAgendamento.Entidades;
using sistemaDeAgendamento.Metodos;
using sistemaDeAgendamento.Services;

namespace sistemaDeAgendamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services.ConfiguraLayout.LayoutDoConsole();
            Agenda_Metodos agenda_Metodo = new Agenda_Metodos();
            try
            {
                int retorno = 0;

                do
                {
                    Console.WriteLine("\n\nSeja Bem Vindo(a): O que deseja fazer:\n\n(1)Criar Perfil\n(2)Acessar Perfil\n ");


                    retorno = Services.ValidarEConverterEntradaDeUsuario.ConverterParaNumero();

                } while (retorno < 1 || retorno > 2);

                if (retorno == 1)
                {
                    Usuario usuario = new Services.NovoUsuario(new Usuario_Metodo()).IniciarNovoPerfil();
                }
                else if (retorno == 2)
                {
                    var usuario = new Services.LoginUsuario();
                    usuario.LogarUsuario();

                }
                while (true)
                {
                    Seletor.MostrarAlternativas();
                    Seletor.IniciarSessaoPosEscolha(Services.Seletor.EscolherMenu(), agenda_Metodo);
                    ConfiguraLayout.LayoutDoConsole();
                }



            }
            catch (Exception ex)
            {
                Services.ConfiguraLayout.ClearLayout();
                Console.WriteLine(ex.Message);

            }
        }
    }
}
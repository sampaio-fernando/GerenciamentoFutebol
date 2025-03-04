using GerenciamentoFutebol.DAO;
using GerenciamentoFutebol.Models;

int opcao;
do
{
    Console.Clear();

    Console.WriteLine("--- GERENCIAMENTO FUTEBOL ---");
    Console.WriteLine("Digite [1] para CADASTRAR times");
    Console.WriteLine("Digite [2] para EXCLUIR times");
    Console.WriteLine("Digite [3] para EDITAR times");
    Console.WriteLine("Digite [4] para VISUALIZAR times");
    Console.WriteLine("Digite [0] para SAIR...");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                Console.Clear();
                Console.WriteLine("--- CADASTRAR TIME ---");

                Times t1 = new Times();
                Console.Write("nome OFICIAL: ");
                t1.nome_oficial = Console.ReadLine();

                Console.Write("nome FANTASIA: ");
                t1.nome_fantasia = Console.ReadLine();

                Console.Write("endereco: ");
                t1.endereco = Console.ReadLine();

                Console.Write("data de fundacao: ");
                t1.dt_fundacao = DateTime.Parse(Console.ReadLine());

                Console.Write("escudo: ");
                t1.escudo = Console.ReadLine();

                Console.Write("telefone: ");
                t1.telefone = Console.ReadLine();

                Console.Write("email: ");
                t1.email = Console.ReadLine();

                Console.Write("estadio: ");
                t1.estadio = Console.ReadLine();

                TimesDAO timeDAO = new TimesDAO();
                timeDAO.InsertTime(t1);

                break;
            }
        case 2:
            {
                Console.Clear();
                Console.WriteLine("--- EXCLUIR TIME ---");

                Times t1 = new Times();
                Console.WriteLine("Digite o id_time: ");
                int id = Convert.ToInt32(Console.ReadLine());

                TimesDAO timeDAO = new TimesDAO();
                timeDAO.DeleteTime(id);

                break;
            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("--- EDITAR TIME ---");

                Times t1 = new Times();

                Console.WriteLine("Digite o id_time: ");
                t1.idtime = Convert.ToInt32(Console.ReadLine());

                Console.Write("nome OFICIAL: ");
                t1.nome_oficial = Console.ReadLine();

                Console.Write("nome FANTASIA: ");
                t1.nome_fantasia = Console.ReadLine();

                Console.Write("endereco: ");
                t1.endereco = Console.ReadLine();

                Console.Write("data de fundacao: ");
                t1.dt_fundacao = DateTime.Parse(Console.ReadLine());

                Console.Write("escudo: ");
                t1.escudo = Console.ReadLine();

                Console.Write("telefone: ");
                t1.telefone = Console.ReadLine();

                Console.Write("email: ");
                t1.email = Console.ReadLine();

                Console.Write("estadio: ");
                t1.estadio = Console.ReadLine();

                TimesDAO timeDAO = new TimesDAO();
                timeDAO.UpdateTime(t1);

                break;
            }
        case 4:
            {

                Console.Clear();
                List<Times> times = new List<Times>();

                Console.WriteLine("--- VISUALIZAR LISTA DE TIMES ---");
               
                foreach (var tim in times)
                {

                    Console.WriteLine($"Id: {tim.idtime}");
                    Console.WriteLine($"Nome Oficial: {tim.nome_oficial}");
                    Console.WriteLine($"Nome Fantasia: {tim.nome_fantasia}");
                    Console.WriteLine($"Endereço: {tim.endereco}");
                    Console.WriteLine($"Data de Fundação: {tim.dt_fundacao}");
                    Console.WriteLine($"URL Escudo: {tim.escudo}");
                    Console.WriteLine($"Telefone: {tim.telefone}");
                    Console.WriteLine($"Email: {tim.email}");
                    Console.WriteLine($"Estadio: {tim.estadio}");
                   
                }
                TimesDAO timesdao = new TimesDAO();
                timesdao.ListaTimes();

                Console.ReadKey();
                break;
            }
    }
} while (opcao != 0);



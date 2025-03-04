using GerenciamentoFutebol.DAO;
using GerenciamentoFutebol.Models;


TimesDAO timeDAO = new TimesDAO();
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
                int opc;
                do
                {
                    Console.Clear();
                    Console.WriteLine("--- CADASTRAR TIME ---");

                    Times t1 = new Times();
                    Console.Write("Nome Oficial: ");
                    t1.nome_oficial = Console.ReadLine();

                    Console.Write("Nome Fantasia: ");
                    t1.nome_fantasia = Console.ReadLine();

                    Console.Write("Endereço: ");
                    t1.endereco = Console.ReadLine();

                    Console.Write("Data de Fundação: ");
                    t1.dt_fundacao = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Escudo: ");
                    t1.escudo = Console.ReadLine();

                    Console.Write("Telefone: ");
                    t1.telefone = Console.ReadLine();

                    Console.Write("Email: ");
                    t1.email = Console.ReadLine();

                    Console.Write("Estadio: ");
                    t1.estadio = Console.ReadLine();

                    timeDAO.InsertTime(t1);

                    Console.WriteLine("\nContinuar cadastrando? Digite -> 1 SIM... 0 -> NÃO");
                    opc = Convert.ToInt32(Console.ReadLine());
                } while (opc != 0);

                break;
            }// Inserir times
        case 2:
            {
                Console.Clear();
                Console.WriteLine("--- EXCLUIR TIME ---");

                Times t1 = new Times();
                Console.WriteLine("Digite o Id do time: ");
                int id = Convert.ToInt32(Console.ReadLine());

               
                timeDAO.DeleteTime(id);
                Console.ReadKey();

                break;
            }//Excluir times
        case 3:
            {
                Console.Clear();
                Console.WriteLine("--- EDITAR TIME ---");

                Times t1 = new Times();

                Console.WriteLine("Digite o id_time: ");
                t1.idtime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPreencha os campos com novos valores");

                Console.Write("Nome oficial: ");
                t1.nome_oficial = Console.ReadLine();

                Console.Write("Nome fantasia: ");
                t1.nome_fantasia = Console.ReadLine();

                Console.Write("Endereço: ");
                t1.endereco = Console.ReadLine();

                Console.Write("Data de fundação: ");
                t1.dt_fundacao = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Escudo: ");
                t1.escudo = Console.ReadLine();

                Console.Write("Telefone: ");
                t1.telefone = Console.ReadLine();

                Console.Write("Email: ");
                t1.email = Console.ReadLine();

                Console.Write("Estadio: \n");
                t1.estadio = Console.ReadLine();

                timeDAO.UpdateTime(t1);

                Console.ReadKey();
                break;
            }// editar times
        case 4:
         {
                Console.Clear();
                Console.WriteLine("--- LISTA DE TIMES ---");

                foreach (var tim in timeDAO.ListaTimes())
                {
                    Console.WriteLine($"Id: {tim.idtime}");
                    Console.WriteLine($"Nome Oficial: {tim.nome_oficial}");
                    Console.WriteLine($"Nome Fantasia: {tim.nome_fantasia}");
                    Console.WriteLine($"Endereço: {tim.endereco}");
                    Console.WriteLine($"Data de fundação: {tim.dt_fundacao}");
                    Console.WriteLine($"Escudo: {tim.escudo}");
                    Console.WriteLine($"Telefone: {tim.telefone}");
                    Console.WriteLine($"Email: {tim.email}");                   
                    Console.WriteLine($"Estádio: {tim.estadio}\n");
                }
                Console.WriteLine("Pressione para voltar ao menu inicial...");
                Console.ReadKey();
                break;
            }//lista de times
        case 0: 
            {
                Console.WriteLine("Obrigado pela interação!");
                break;
            }//sair
    }
} while (opcao != 0);



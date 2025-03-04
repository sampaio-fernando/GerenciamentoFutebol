using GerenciamentoFutebol.DAO;
using GerenciamentoFutebol.Models;

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


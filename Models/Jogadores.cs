using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFutebol.Models
{
    internal class Jogadores
    {
        public int idjogador;
        public string nome;
        public DateTime dt_nascimento;
        public string sexo;
        public string cpf;
        public string rg;
        public string email;
        public double peso;
        public double altura;
        public string telefone;
        public string nacionalidade;
        public string apelido;
        public string posicao;
        public int n_camisa;
        public string foto;
        public string time_anterior;
        public DateTime data_hora_inicio;
        public DateTime data_hora_fim;
        public int fk_idtime;
    }
}

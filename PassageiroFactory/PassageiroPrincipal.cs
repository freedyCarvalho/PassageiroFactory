using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PassageiroPrincipal : Passageiro, IPassageiroPrincipal
    {
        public decimal Renda { get; private set; }
        public string RG { get; private set; }
        public DateTime DataExpedicao { get; private set; }
        public string Telefone { get; private set; }

        public virtual ICollection<Passagem> Passagem { get; set; }

        public PassageiroPrincipal()
        {

        }

        public void AtribuirValores(string nome, DateTime nascimento, string cpf, string email, bool isPrincipal, decimal renda, string rg, DateTime dataExpedicao, string telefone)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Email = email;
            IsPrincipal = isPrincipal;
            Renda = renda;
            RG = rg;
            DataExpedicao = dataExpedicao;
            Telefone = telefone;
        }
    }
}

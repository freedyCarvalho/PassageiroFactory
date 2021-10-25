using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    interface IPassageiroPrincipal
    {
        void AtribuirValores(string nome, DateTime nascimento, string cpf, string email, bool isPrincipal, decimal renda, string rg, DateTime dataExpedicao, string telefone);
    }
}

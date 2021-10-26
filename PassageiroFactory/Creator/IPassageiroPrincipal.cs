using System;

namespace SimpleFactory.Creator
{
    interface IPassageiroPrincipal
    {
        void AtribuirValores(string nome, DateTime nascimento, string cpf, string email, bool isPrincipal, 
                             decimal renda, string rg, DateTime dataExpedicao, string telefone);
    }
}

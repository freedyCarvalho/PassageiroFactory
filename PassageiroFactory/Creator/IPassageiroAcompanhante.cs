using SimpleFactory.ConcretePassageiro;
using SimpleFactory.DTO;
using System.Collections.Generic;

namespace SimpleFactory.Creator
{
    public interface IPassageiroAcompanhante
    {
        List<PassageiroAcompanhante> AtribuirValores(CriarPassagemDTO passagem);
    }
}

using SimpleFactory.ConcretePassageiro;
using SimpleFactory.DTO;
using System.Collections.Generic;

namespace SimpleFactory.Creator
{
    public interface IPassageiroEspecial
    {
        List<PassageiroEspecial> AtribuirValores(CriarPassagemDTO passagem);
    }
}

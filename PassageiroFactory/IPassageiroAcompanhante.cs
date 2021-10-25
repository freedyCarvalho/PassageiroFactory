using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface IPassageiroAcompanhante
    {
        List<PassageiroAcompanhante> AtribuirValores(CriarPassagemDTO passagem);
    }
}

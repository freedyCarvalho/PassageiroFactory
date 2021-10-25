using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface IPassageiroEspecial
    {
        List<PassageiroEspecial> AtribuirValores(CriarPassagemDTO passagem);
    }
}

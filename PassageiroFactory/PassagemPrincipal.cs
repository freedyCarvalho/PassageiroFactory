using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PassagemPrincipal : Passagem, IPassageiroPrincipal
    {
        public PassagemPrincipal()
        {
        }

        public void AtribuirValores(PassageiroPrincipal principal)
        {
            _ = new Passagem(
                                principal.PassageiroID,
                                principal.Nome,
                                principal.Nascimento,
                                principal.CPF,
                                principal.Email,
                                true,
                                null,
                                null
                        );
                                
        }
    }
}

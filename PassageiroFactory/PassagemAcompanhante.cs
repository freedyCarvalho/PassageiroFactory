using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PassagemAcompanhante : Passagem, IPassagemAcompanhante
    {
        public PassagemAcompanhante()
        {
        }

        public void AtribuirValores(PassageiroAcompanhante acompanhante)
        {
            string email = null;
            bool isPrincipal = false;
            string parentesco = null;

            _ = new Passagem(
                                acompanhante.PassageiroID,
                                acompanhante.Nome,
                                acompanhante.Nascimento,
                                acompanhante.CPF,
                                email,
                                isPrincipal,
                                acompanhante.TipoAcompanhante,
                                parentesco
                        );
        }
    }
}

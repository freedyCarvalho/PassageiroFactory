using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PassagemFactory : Passagem
    {
        public static Passagem CriarPassagem(char tipo)
        {
            Passagem passagem = tipo switch
            {
                'P' => new PassagemPrincipal(),
                'A' => new PassagemAcompanhante(),
                'E' => new PassagemEspecial(),
                _ => throw new ApplicationException("A passagem não pode ser criada"),
            };

            return passagem;
        }

    }
}

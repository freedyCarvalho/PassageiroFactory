using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PassageiroFactory
    {
        public static Passageiro CriarPassageiro(char tipo)
        {
            Passageiro passageiro = tipo switch
            {
                'P' => new PassageiroPrincipal(),
                'A' => new PassageiroAcompanhante(),
                'E' => new PassageiroEspecial(),
                _ => throw new ApplicationException("O passageiro não pode ser criado"),
            };

            return passageiro;
        }
    }
}

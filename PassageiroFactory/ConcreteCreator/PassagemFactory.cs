using SimpleFactory.ConcretePassageiro.Enum;
using SimpleFactory.ConcretePassagem;
using System;

namespace SimpleFactory.ConcreteCreator
{
    public class PassagemFactory : Passagem
    {
        public static Passagem CriarPassagem(Enum tipo)
        {
            Passagem passagem = tipo switch
            {
                PassageiroEnum.Principal => new PassagemPrincipal(),
                PassageiroEnum.Acompanhante => new PassagemAcompanhante(),
                PassageiroEnum.Especial => new PassagemEspecial(),
                _ => throw new ApplicationException("A passagem não pode ser criada"),
            };

            return passagem;
        }

    }
}

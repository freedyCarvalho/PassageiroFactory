using SimpleFactory.ConcretePassageiro;
using SimpleFactory.ConcretePassageiro.Enum;
using System;

namespace SimpleFactory.ConcreteCreator
{
    public class PassageiroFactory
    {
        public static Passageiro CriarPassageiro(Enum tipo)
        {
            Passageiro passageiro = tipo switch
            {
                PassageiroEnum.Principal => new PassageiroPrincipal(),
                PassageiroEnum.Acompanhante => new PassageiroAcompanhante(),
                PassageiroEnum.Especial => new PassageiroEspecial(),
                _ => throw new ApplicationException("O passageiro não pode ser criado"),
            };

            return passageiro;
        }
    }
}

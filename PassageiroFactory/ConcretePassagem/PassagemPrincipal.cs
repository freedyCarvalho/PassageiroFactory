using SimpleFactory.ConcretePassageiro;
using SimpleFactory.Creator;

namespace SimpleFactory.ConcretePassagem
{
    public class PassagemPrincipal : Passagem, IPassagemPrincipal
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

using SimpleFactory.ConcretePassageiro;
using SimpleFactory.Creator;

namespace SimpleFactory.ConcretePassagem
{
    public class PassagemEspecial : Passagem, IPassagemEspecial
    {
        public PassagemEspecial()
        {
        }

        public void AtribuirValores(PassageiroEspecial especial)
        {
            string email = null;
            bool isPrincipal = false;
            string tipoAcompanhante = null;

            _ = new Passagem(
                                especial.PassageiroID,
                                especial.Nome,
                                especial.Nascimento,
                                especial.CPF,
                                email,
                                isPrincipal,
                                tipoAcompanhante,
                                especial.Parentesco
                        );
        }
    }
}

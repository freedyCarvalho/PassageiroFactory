using SimpleFactory.Creator;
using SimpleFactory.DTO;
using System.Collections.Generic;

namespace SimpleFactory.ConcretePassageiro
{
    public class PassageiroEspecial : Passageiro, IPassageiroEspecial
    {
        public string Parentesco { get; private set; }

        public PassageiroEspecial()
        {
        }

        public List<PassageiroEspecial> AtribuirValores(CriarPassagemDTO passagem)
        {
            var lista = new List<PassageiroEspecial>();

            foreach (var passageiro in passagem.Especial)
            {
                var especial = new PassageiroEspecial
                {
                    Nome = passageiro.Nome,
                    Nascimento = passageiro.Nascimento,
                    IsPrincipal = false,
                    Parentesco = passageiro.Parentesco
                };

                lista.Add(especial);
            }

            return lista;
        }
    }
}

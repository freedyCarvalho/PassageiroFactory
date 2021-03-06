using SimpleFactory.Creator;
using SimpleFactory.DTO;
using System.Collections.Generic;

namespace SimpleFactory.ConcretePassageiro
{
    public class PassageiroAcompanhante : Passageiro, IPassageiroAcompanhante
    {
        public string TipoAcompanhante { get; private set; }

        public PassageiroAcompanhante()
        {
        }

        public List<PassageiroAcompanhante> AtribuirValores(CriarPassagemDTO passagem)
        {
            var lista = new List<PassageiroAcompanhante>();

            foreach (var passageiro in passagem.Acompanhante)
            {
                var acompanhante = new PassageiroAcompanhante
                {
                    Nome = passageiro.Nome,
                    Nascimento = passageiro.Nascimento,
                    CPF = passageiro.CPF,
                    IsPrincipal = false,
                    TipoAcompanhante = passageiro.TipoAcompanhante
                };

                lista.Add(acompanhante);
            }

            return lista;    
            
        }
    }

}

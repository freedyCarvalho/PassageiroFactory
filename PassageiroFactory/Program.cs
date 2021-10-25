using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            CriarPassagemDTO agencia = new CriarPassagemDTO();

            agencia.Nome = "Roberto Dantas";
            agencia.Nascimento = DateTime.ParseExact("01/05/1980", "dd/MM/yyyy", null);
            agencia.CPF = "12345678900";
            agencia.IsPrincipal = true;
            agencia.Principal.Email = "roberto.dantas@gmail.com";
            agencia.Principal.Renda = 1000;
            agencia.Principal.RG = "4584595109";
            agencia.Principal.DataExpedicao = DateTime.ParseExact("08/05/2000", "dd/MM/yyyy", null);
            agencia.Principal.Telefone = "11954774237";

            agencia.Acompanhante[0].Nome = "Fernanda Gomes";
            agencia.Acompanhante[0].Nascimento = DateTime.ParseExact("12/08/1982", "dd/MM/yyyy", null);
            agencia.Acompanhante[0].TipoAcompanhante = "Namorada";
            agencia.Acompanhante[0].CPF = "558741598";

            agencia.Acompanhante[1].Nome = "Gabriel Dantas";
            agencia.Acompanhante[1].Nascimento = DateTime.ParseExact("22/11/1983", "dd/MM/yyyy", null);
            agencia.Acompanhante[1].TipoAcompanhante = "Irmão";
            agencia.Acompanhante[1].CPF = "558741598";
            
            agencia.Acompanhante[2].Nome = "Marcos Gomes";
            agencia.Acompanhante[2].Nascimento = DateTime.ParseExact("12/08/1982", "dd/MM/yyyy", null);
            agencia.Acompanhante[2].TipoAcompanhante = "Cunhado";
            agencia.Acompanhante[2].CPF = "558741598";

            agencia.Especial[0].Nome = "Gustavo Dantas";
            agencia.Especial[0].Nascimento = DateTime.ParseExact("06/04/2012", "dd/MM/yyyy", null);
            agencia.Especial[0].Parentesco = "Filho";

            agencia.Especial[0].Nome = "Gilson Dantas";
            agencia.Especial[0].Nascimento = DateTime.ParseExact("06/04/2012", "dd/MM/yyyy", null);
            agencia.Especial[0].Parentesco = "Filho";


            var passageiroPrincipal = (PassageiroPrincipal)PassageiroFactory.CriarPassageiro('T');
            passageiroPrincipal.AtribuirValores(
                agencia.Nome,
                agencia.Nascimento,
                agencia.CPF,
                agencia.Principal.Email,
                agencia.IsPrincipal,
                agencia.Principal.Renda,
                agencia.Principal.RG,
                agencia.Principal.DataExpedicao,
                agencia.Principal.Telefone              
                );

            var passagemPrincipal = (PassagemPrincipal)PassagemFactory.CriarPassagem('T');
            passagemPrincipal.AtribuirValores(passageiroPrincipal);

            // aqui eu gravaria no banco



            if (agencia.Acompanhante != null)
            {
                var passageiroAcompanhante = (PassageiroAcompanhante)PassageiroFactory.CriarPassageiro('A');

                var listaPassageiroAcompanhante = passageiroAcompanhante.AtribuirValores(agencia);

                foreach (var listaAcompanhante in listaPassageiroAcompanhante)
                {
                    var passagemAcompanhante = (PassagemAcompanhante)PassagemFactory.CriarPassagem('A');
                    passagemAcompanhante.AtribuirValores(listaAcompanhante);

                    // aqui eu gravo no banco
                }
            }


            if (agencia.Especial != null)
            {
                var passageiroEspecial = (PassageiroEspecial)PassageiroFactory.CriarPassageiro('E');

                var listaPassageiroEspecial = passageiroEspecial.AtribuirValores(agencia);

                foreach (var listaEspecial in listaPassageiroEspecial)
                {
                    var passagemEspecial = (PassagemEspecial)PassagemFactory.CriarPassagem('E');
                    passagemEspecial.AtribuirValores(listaEspecial);

                    // aqui eu gravo no banco
                }
            }
        }
    }
}

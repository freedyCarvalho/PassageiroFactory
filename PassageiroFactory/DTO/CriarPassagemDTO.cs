using System;
using System.Collections.Generic;

namespace SimpleFactory.DTO
{
    public class CriarPassagemDTO
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }        
        public bool IsPrincipal { get; set; }
        public Principal Principal { get; set; }
        public List<Acompanhante> Acompanhante { get; set; }
        public List<Especial> Especial { get; set; }
    }

    public class Principal
    {
        public string Email { get; set; }
        public decimal Renda { get; set; }
        public string RG { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string Telefone { get; set; }
    }

    public class Acompanhante
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string TipoAcompanhante { get; set; }
        public string CPF { get; set; }
    }

    public class Especial
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Parentesco { get; set; }
    }
}

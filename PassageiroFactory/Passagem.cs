using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Passagem
    {
        public Guid PassagemID { get; private set; }
        public Guid PassageiroID { get; private set; }
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string? CPF { get; private set; }
        public string? Email { get; private set; }
        public bool IsPrincipal { get; private set; }
        public string TipoAcompanhante { get; private set; }
        public string Parentesco { get; private set; }
    
        public virtual PassageiroPrincipal PassageiroPrincipal { get; set; }

        protected Passagem()
        {
        }

        public Passagem(Guid passageiroID, string nome, DateTime nascimento, string cPF, 
                        string email, bool isPrincipal, string tipoAcompanhante, string parentesco)
        {
            PassageiroID = passageiroID;
            Nome = nome;
            Nascimento = nascimento;
            CPF = cPF;
            Email = email;
            IsPrincipal = isPrincipal;
            TipoAcompanhante = tipoAcompanhante;
            Parentesco = parentesco;
        }

    }

}

using System;

namespace SimpleFactory.ConcretePassageiro
{
    public abstract class Passageiro
    {
        public Guid PassageiroID { get; set; } = new Guid();
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public bool IsPrincipal { get; set; }

    }
}

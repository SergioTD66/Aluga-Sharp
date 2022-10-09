using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluga_sharp
{
    internal class Cliente
    {
        string _nome;
        string _email;
        string _celular;

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Celular { get => _celular; set => _celular = value; }
    }
}

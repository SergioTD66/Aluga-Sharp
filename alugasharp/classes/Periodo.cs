using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluga_sharp
{
    enum DiaSemana
    {
        Domingo = 1,
        Segunda_Feira = 2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_Feira = 6,
        Sabado = 7
    }
    internal class Periodo
    {
        DiaSemana diaSemana;
        Horario _horarios;
        float _preco;
        bool _estaAtiva;

        public float Preco { get => _preco; set => _preco = value; }
        public bool estaAtiva { get => _estaAtiva; set => _estaAtiva = value; }
    }
}

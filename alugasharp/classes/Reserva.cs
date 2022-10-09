using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluga_sharp
{
    internal class Reserva
    {
        List<DisponilidadeSala> _salasAlugadas;
        List<Equipamento> _equipamentos;
        List<Servico> _servicos;
        List<Objetos> _objetos;

        public bool FazerContratacao()
        {
            return true;
        }

    }
}

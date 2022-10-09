using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluga_sharp
{
    internal class Equipamentos
    {
        string _nome;
        string _descricao;
        int _voltagem; //110 ou 220
        float _peso;
        string _volume;
        float _custoTotal;
        float _custoSeguro;
        float _custoHora;

        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int voltagem { get => _voltagem; set => _voltagem = value; }
        public float Peso { get => _peso; set => _peso = value; }
        public string Volume { get => _volume; set => _volume = value; }
        public float CustoTotal { get => _custoTotal; set => _custoTotal = value; }
        public float CustoSeguro { get => _custoSeguro; set => _custoSeguro = value; }
        public float CustoHora { get => _custoHora; set => _custoHora = value; }
    }
}

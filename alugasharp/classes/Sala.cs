using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluga_sharp
{
    internal class Sala
    {
        int _id;
        string _identificacao;
        string _descricao;
        int _estado;
        int _voltagem;
        int _medidaLado1EmMetros;
        int _medidalado2EmMetros;
        int _numeroMaximoDePessoas;
        int _janelas;
        Endereco _localizacao;
        bool _temBanheiro;
        bool _temEstacionamento;
        bool _temArCondicionado;
        bool _temSeguro;
        List<string> _fotos;

        public int Id { get => _id; set => _id = value; }
        public string Indentificacao { get => _indentificacao; set => _indentificacao = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public int Voltagem { get => _voltagem; set => _voltagem = value; }
        public int MedidaLado1EmMetros { get => _medidaLado1EmMetros; set => _medidaLado1EmMetros = value; }
        public int MedidaLado2EmMetros { get => _medidaLado2EmMetros; set => _medidaLado2EmMetros = value; }
        public int NumeroMaximoDePessoas { get => _numeroMaximoDePessoas; set => _numeroMaximoDePessoas = value; }
        public int Janelas { get => _janelas; set => _janelas = value; }
        public bool TemBanheiro { get => _temBanheiro; set => _temBanheiro = value; }
        public bool TemEstacionamento { get => _temEstacionamento; set => _temEstacionamento = value; }
        public bool TemArCondicionado { get => _temArCondicionado; set => _temArCondicionado = value; }
        public bool TemSeguro { get => _temSeguro; set => _temSeguro = value; }
    }
}

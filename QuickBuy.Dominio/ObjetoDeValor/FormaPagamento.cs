using QuickBuy.Dominio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }

        }
        public bool ECartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaCredito; }

        }
        public bool EDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }

        }
        public bool ENaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }

        }

    }
}

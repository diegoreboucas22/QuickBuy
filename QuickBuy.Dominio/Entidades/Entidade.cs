using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        public List<string> _mensagemValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
    }
}

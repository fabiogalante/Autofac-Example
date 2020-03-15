using System;

namespace WebAppTest.Data.Model
{
    public class CartaoCredito
    {
        public Guid CartaoCreditoGuid { get; set; }

        public string Bandeira { get; set; }

        public string NumeroCartao { get; set; }
    }
}

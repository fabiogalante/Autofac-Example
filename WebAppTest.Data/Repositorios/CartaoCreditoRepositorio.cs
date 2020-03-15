using System;
using System.Collections.Generic;
using WebAppTest.Data.Interfaces;
using WebAppTest.Data.Model;

namespace WebAppTest.Data.Repositorios
{
    public class CartaoCreditoRepositorio : ICartaoCreditoRepositorio
    {
        public int ObterNumeroCartao(Guid guid)
        {
            return 15;
        }

        public CartaoCredito ObterCartao(Guid guid)
        {
            return new CartaoCredito
            {
                Bandeira = "Master",
                CartaoCreditoGuid = Guid.NewGuid(),
                NumeroCartao = "FDSFA934009REWPORIPEWO"

            };
        }

        public IEnumerable<CartaoCredito> ObterCartaoCreditos()
        {
            throw new NotImplementedException();
        }
    }
}

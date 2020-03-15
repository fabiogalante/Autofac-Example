using System;
using System.Collections.Generic;
using WebAppTest.Data.Model;

namespace WebAppTest.Data.Interfaces
{
    public interface ICartaoCreditoRepositorio
    {
        int ObterNumeroCartao(Guid guid);

        CartaoCredito ObterCartao(Guid guid);

        IEnumerable<CartaoCredito> ObterCartaoCreditos();
    }
}

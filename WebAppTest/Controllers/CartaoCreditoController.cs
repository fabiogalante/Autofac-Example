using System;
using System.Web.Http;
using WebAppTest.Data.Interfaces;

namespace WebAppTest.Controllers
{
    public class CartaoCreditoController : ApiController
    {
        private readonly ICartaoCreditoRepositorio _cartaoCreditoRepositorio;

        public CartaoCreditoController(ICartaoCreditoRepositorio cartaoCreditoRepositorio)
        {
            _cartaoCreditoRepositorio = cartaoCreditoRepositorio;
        }


        public IHttpActionResult Get()
        {
            var cartao = _cartaoCreditoRepositorio.ObterCartao(Guid.NewGuid());

            return Ok(cartao);
        }
    }
}

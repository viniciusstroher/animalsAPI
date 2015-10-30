using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace AnimaisAPI.Controllers
{
    public class DefaultController : ApiController
    {
        /// <summary>
        ///     Método simples para efetuar autenticação na api de testes.
        /// </summary>
        [HttpGet, Route("Authorize"), ApiExplorerSettings(IgnoreApi = true)]
        public void Authorize() { }

        /// <summary>
        ///     Exemplo básico de get.
        /// </summary>
        /// <returns>Retorna alguns valores.</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        ///     Exemplo básico de post.
        /// </summary>
        /// <param name="value">Valor default.</param>
        public void Post([FromBody] string value) { }

        /// <summary>
        ///     Exemplo básico de put.
        /// </summary>
        /// <param name="value">Valor padrão.</param>
        public void Put([FromBody] string value) { }

        /// <summary>
        ///     Exemplo básico de delete.
        /// </summary>
        /// <param name="value">Valor padrão.</param>
        public void Delete([FromBody] string value) { }
    }
}

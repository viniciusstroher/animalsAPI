using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace AnimaisAPI.AppCode.WebApiFilters
{
    public class AuthenticationFilterAttribute : AuthorizationFilterAttribute
    {
        #region Private Methods

        /// <summary>
        /// Adquire o enderço de IP do cliente de chamada atual.
        /// </summary>
        /// <param name="context">Contexto de requisição do cliente atual.</param>
        /// <returns>O endereço IP do cliente.</returns>
        private string getClientIp(HttpActionContext context)
        {
            if (context.Request.Properties.ContainsKey("MS_HttpContext"))
                return ((HttpContextWrapper)context.Request.Properties["MS_HttpContext"]).Request.UserHostAddress;

            if (!context.Request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
                return HttpContext.Current != null ? HttpContext.Current.Request.UserHostAddress : null;

            RemoteEndpointMessageProperty prop = (RemoteEndpointMessageProperty)context.Request.Properties[RemoteEndpointMessageProperty.Name];
            return prop.Address;
        }

        private void validaAutenticacao(HttpActionContext actionContext, string token)
        {
            /* Todo: Efetuar uma validação mais segura, por exemplo, com tokens cadastrados em um banco de dados. */
            if (token != Constants.AuthenticationTokenValue)
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new { Message = "Token de acesso inválido." });
        }

        private static bool skipAuthorization(HttpActionContext actionContext)
        {
            return actionContext.ActionDescriptor.GetCustomAttributes<System.Web.Http.AllowAnonymousAttribute>().Any()
                   || actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<System.Web.Http.AllowAnonymousAttribute>().Any();
        }

        #endregion

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (skipAuthorization(actionContext))
                return;

            string token = actionContext.Request.Headers.Contains(Constants.AuthenticationTokenKey) ? actionContext.Request.Headers.GetValues(Constants.AuthenticationTokenKey).First() : string.Empty;

            if (string.IsNullOrEmpty(token))
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new { Message = "Acesso Negado." });
            else
                this.validaAutenticacao(actionContext, token);
        }
    }
}

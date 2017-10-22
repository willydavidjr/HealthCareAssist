using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using Konzole.HealthCareAssistSystem;
using Konzole.HealthCareAssistSystem.Providers.Interface;

namespace Konzole.HealthCareAssistSystem.Web.Controllers.Api
{
    public static class ApiControllerExtensions
    {
        #region Build response message helpers

        public static HttpResponseMessage BuildResponse(this ApiController controller, HttpStatusCode statusCode)
        {
            return BuildResponse(controller, statusCode, null);
        }

        public static HttpResponseMessage BuildResponse(this ApiController controller, HttpStatusCode statusCode, object model)
        {
            return BuildResponse(controller, statusCode, model, null);
        }

        public static HttpResponseMessage BuildResponse(this ApiController controller, HttpStatusCode statusCode, object model, string locationHeaderValue)
        {
            HttpResponseMessage response;

            if (model == null)
            {
                response = controller.Request.CreateResponse(statusCode);
            }
            else
            {
                response = controller.Request.CreateResponse(statusCode, model);
            }

            if (!string.IsNullOrEmpty(locationHeaderValue))
            {
                response.Headers.Location = new Uri(controller.Request.RequestUri, locationHeaderValue);
            }

            return response;
        }

        #endregion

        #region Logged in user helpers

        public static MembershipUser GetCurrentUser(this ApiController controller)
        {
            return Membership.GetUser();
        }

       

        /// <summary>
        /// This gets set in the Global.asax.cs, and in testing shoud be set in the arrange part.
        /// </summary>
       
        #endregion

    }
}

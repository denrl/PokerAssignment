using System.Collections.Generic;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Web.Http.Description;
using PokerAssignment;
using PokerAssignment.Data;
using AutoMapper;

namespace PokerRestApi.Controllers
{

    /// <summary>
    /// PokerAssignment api
    /// </summary>
    public class PokerController : ApiController
    {

        private RuleProcessor processor = new RuleProcessor();

        /// <summary>
        /// Ranks hands
        /// </summary>
        /// <remarks>
        /// List of players in the order of winning (the winner is the first on the list)
        /// </remarks>
        /// <param name="data">Playing hands</param>
        /// <returns></returns>
        /// <response code="200">string list</response>
        [ResponseType(typeof(IList<string>))]
        public HttpResponseMessage Post(IList<PlayingHand> data)
        {
            return Request.CreateResponse(HttpStatusCode.OK, processor.rank(data));
        }

        
    }
}

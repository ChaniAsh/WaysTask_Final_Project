using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dto;
using System.Web.Http.Cors;

namespace WebApplicationReact.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/position")]
    public class PositionController : ApiController
    {
        
        ConnectDb connect = new ConnectDb();
        // GET: api/Positions
        //[HttpGet]
        //[Route("getAllPositions")]
        //public IHttpActionResult GetPos()
        //{
        //    return (IHttpActionResult)connect.GetAllPositions();
        //}

        // GET: api/TrafficDetails/5
        //public TrafficDetails_Dto Get(string id)
        //{
        //    return connect.GetTrafficDetailsByCustomerId(id);
        //}

        // POST: api/TrafficDetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TrafficDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TrafficDetails/5
        public void Delete(int id)
        {
        }
    }
}

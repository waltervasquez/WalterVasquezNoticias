using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Repository;

namespace ApiRest.Controllers
{
    public class ANewsController : ApiController
    {
        [Route("api/getListNews")]
        [HttpGet]
        public  IHttpActionResult getListNews()
        {
            try
            {
                RepositoryNews news = new RepositoryNews();

                return Ok(news.ListNews());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

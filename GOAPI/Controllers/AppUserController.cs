using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess.Services;
using System.Threading.Tasks;
using GOAPI.Models;

namespace GOAPI.Controllers
{
    public class AppUserController : ApiController
    {
        IAppUserService _appUserService;
        public AppUserController()
        {
        }
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }


        // GET: /api/ValidateAppUser
        [Route("api/ValidateAppUser")]
        [HttpGet]
        public IHttpActionResult ValidateAppUser([FromBody]LoginModel value)
        {
            string username = value.Username;
            string password = value.Password;

            var resultData = _appUserService.ValidateAppUser(username, password);
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}
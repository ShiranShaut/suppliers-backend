using suppliers_backend.DAL;
using suppliers_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace suppliers_backend.Controllers
{
    [RoutePrefix("user")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("signin")]
        public IHttpActionResult SignIn(UserModel i_UserModel)
        {
            if (i_UserModel == null)
                return BadRequest("User Not Valid");

            try
            {
                UserDal.SignIn(i_UserModel);
                return Ok("User Saved Successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login(UserModel i_UserModel)
        {
            if (i_UserModel == null)
                return BadRequest("User Not Valid");

            try
            {
                UserDal.LogIn(i_UserModel);
                return Ok("User Saved Successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaimsManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ClaimsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController:Controller
    {
       
        [HttpGet]
        public IActionResult LoginAuthentication( string username,string password )
        {
            Admin ad = new Admin();
            ad.Name = username;
            ad.Password = password;
            LoginAuth login = new LoginAuth();
            int result = login.Login(ad);
            return Ok(result);
        }
    }
}

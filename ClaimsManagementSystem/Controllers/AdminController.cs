using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClaimsManagementSystem.Model;
using ClaimsManagementSystem;

namespace ClaimsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {

        [HttpGet]
        public IActionResult GetAdmin(String username,String password)
        {
            AdminProcess adminProcess = new AdminProcess();
            var result= adminProcess.Login(username,password);
            return Ok(result);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
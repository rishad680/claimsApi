using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClaimsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : Controller
    {

        [HttpPost("AddPolicy")]
        public void Post(String PolicyName,String PolicyHolder)
        {
            PolicyProcess policyProcess = new PolicyProcess();
            int result = policyProcess.AddPolicy(PolicyName, PolicyHolder);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClaimsManagementSystem.Model;

namespace ClaimsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : Controller
    {

        [HttpGet]
        public ActionResult<List<ClaimDetails>> GetClaimDetails()
        {
            ClaimProcess claimProcess = new ClaimProcess();
            List<ClaimDetails> claimDetails = claimProcess.DisplayClaimDetails();
            return Ok(claimDetails);
        }

        [HttpPut("{id}")]
        public ActionResult<int> Put(Claim claim,int id)
        {
            ClaimProcess claimProcess = new ClaimProcess();
            claim.ClaimId = id;
            int status = claimProcess.UpdateClaimDetails(claim);
            return Ok(status);
        }


    }
}
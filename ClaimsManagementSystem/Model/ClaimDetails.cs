using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsManagementSystem.Model
{
    public class ClaimDetails
    {
        public int ClaimId { get; set; } = 0;
        public int ClaimNumber { get; set; } = 0;
        public double ClaimAmount { get; set; } = 0;
        public DateTime ClaimRaisedDate { get; set; }
        public String ClaimRemarks { get; set; } = "";
        public String ClaimDocument { get; set; } = "";
        public int Id { get; set; } = 0;
        public string PolicyNumber { get; set; } = "";
        public string PolicyHolderName { get; set; } = "";
    }
}

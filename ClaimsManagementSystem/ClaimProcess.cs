using ClaimsManagementSystem.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsManagementSystem
{
    public class ClaimProcess
    {
        public List<ClaimDetails> DisplayClaimDetails()
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\mydb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<ClaimDetails> claim = db.Query<ClaimDetails>("select pl.number, pl.older_name, cl.number, cl.amount, cl.raised_date, cl.remarks, cl.document from policy pl join claim cl on pl.id = cl.id").ToList();
                return claim;
            }
        }

        public int UpdateClaimDetails(Claim claim)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\mydb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string sql = "UPDATE claim set number=@ClaimNumber,amount=@ClaimAmount ,raised_date=@ClaimRaisedDate,remarks=@ClaimRemarks,document=@ClaimDocument WHERE id = @ClaimId ";
                int result=db.Execute(sql, claim);
                return result;
            }
        }
    }
}

using System.Configuration;
using System.Collections.Generic;

using System.Linq;
using ClaimsManagementSystem.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ClaimsManagementSystem
{
    public class AdminProcess
    {
        
        public int Login(string username,string password)
        {
            int result = 0;
            using (IDbConnection db =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\mydb.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                List<Admin> admin= db.Query<Admin>("Select pk_ad_id as Id,ad_name as Name,ad_password as Password From admin").ToList();

                foreach(var ad in admin)
                {
                    if (ad.Name.Equals(username) && ad.Password.Equals(password))
                    {
                        result = 1; ;
                    }
                    
                }
                return result;
            }
        }
    }
}

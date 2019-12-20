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
    public class LoginAuth
    {
        
        public int Login(Admin info)
        {
           
            int result = 0;
            using (IDbConnection db = new SqlConnection(_connectionString))
            {


                var sql = "Select id as Id,name as Name,password as Password From admin where Name = @Name";
                List<Admin> admin = db.Query<Admin>(sql, info).ToList();

                foreach (var ad in admin)
                {
                    if (ad.Name.Equals(info.Name) && ad.Password.Equals(info.Password))
                    {
                        result = 1;
                    }
                }
                return result;
            }
        }
    }
}

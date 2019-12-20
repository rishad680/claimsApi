using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsManagementSystem
{
    public class PolicyProcess
    {

        public int AddPolicy(String PolicyName,String HolderName)
        {
            using (IDbConnection db =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\mydb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                int n = db.Execute("insert into policy values(@PolicyName,@HolderName)");
                return n;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Project_Hospital
{
    internal class connection
    {
       public SqlConnection sqlConnection() 
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1F6TS0S\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True;Encrypt=False");
            conn.Open();
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;


namespace ClinicManagementSystem
{
    internal class Connection
    {
        private string connectionString =
            @"Server=localhost\SQLExpress;Database=Clinic;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            
            return con;
        }
    }
     
    }

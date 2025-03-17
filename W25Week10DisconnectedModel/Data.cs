using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace W25Week10DisconnectedModel
{
    public class Data
    {
        public static string GetConnectionString()
        { 
            return ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        }

        public DataTable GetAllProducts()
        {
            string query = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";

            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            adp.Fill(ds, "Products");

            DataTable tbl = ds.Tables["Products"];
            return tbl;
        }
    }
}

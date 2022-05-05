using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using AdoMVC.Models;
using System.Data;
namespace AdoMVC.DAL
{
    public class CustomerDAL
    {

        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;

                    }


                }
            }
            return listCustomer;
        }
        public int NewCustomer(Customer cust)
        {
            int result;
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("NewCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", cust.CustomerID);
            cmd.Parameters.AddWithValue("@cname", cust.CustomerName);
            cmd.Parameters.AddWithValue("@email", cust.EmailID);
            cmd.Parameters.AddWithValue("@mob", cust.MobileNo);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DelCustomer(Customer obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("DelCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", obj.CustomerID);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int UpdCustomer(Customer cobj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("UpdCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", cobj.CustomerID);
            cmd.Parameters.AddWithValue("@cname", cobj.CustomerName);
            cmd.Parameters.AddWithValue("@email", cobj.EmailID);
            cmd.Parameters.AddWithValue("@mobno", cobj.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public List<Customer> GetCustomerByID(int CustomerID)
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetCustomerByID", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.Add("@Id", SqlDbType.Int);
                    cmd.Parameters["@Id"].Value = CustomerID;
                    cmd.CommandType = CommandType.StoredProcedure;

                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;
        }
    }

}






        

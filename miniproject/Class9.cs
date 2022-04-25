using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp3
{
    class Class9
    {
        class Program1
        {
            public void producttable()
            {
                SqlConnection con = new SqlConnection("Data source = DESKTOP-6ROTE51 ; database= task;user id = sa; password =P@ssword");
                SqlDataAdapter da1 = new SqlDataAdapter("select ProductId,ProductName,Price,DOM,Expirydate from product_table", con);
                DataSet ds = new DataSet();
                da1.Fill(ds, "Trail");
                foreach (DataRow dr in ds.Tables["Trail"].Rows)
                {
                    Console.WriteLine("ProductId : " + dr[0] + " ProductName : " + dr[1] + "|   Price : " + dr[2] + "|   DOM : " + dr[3] + "|   Expirydate : " + dr[4]);
                }
            }


            public void insert()
            {
                SqlConnection con1 = new SqlConnection("Data source = DESKTOP-6ROTE51; database =task; user id = sa;password = P@ssword");
                Console.WriteLine("Enter the name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Gender M or F");
                string Gender = Console.ReadLine();
                Console.WriteLine("Enter the DOM ");
                string Dateofbirth = Console.ReadLine();
                Console.WriteLine("Enter the EmailId");
                string EmailId = Console.ReadLine();
                Console.WriteLine("Enter the Contact number");
                string Contactnumber = Console.ReadLine();
                Console.WriteLine("Enter your city ");
                string City = Console.ReadLine();
                string salqry = "insert customertable values( '" + Name + "','" + Gender + "','" + Dateofbirth + "','" + Contactnumber + "','" + EmailId + "','" + City + "')";
                SqlCommand cmd = new SqlCommand(salqry, con1);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                Console.WriteLine("Row Inserted");

            }
            public void purchasetable()
            {
                Console.WriteLine("Enter the cust Id");
                int custid = Convert.ToInt32(Console.ReadLine());
                SqlConnection conn1 = new SqlConnection("Data source =  DESKTOP-6ROTE51; database=task;user id = sa; password =P@ssword");
                SqlDataAdapter da = new SqlDataAdapter("select CustID,Totalamount,BillNo from Purchasetable where CustID= " + custid + "", conn1);
                DataSet ds = new DataSet();
                da.Fill(ds, "Test");

                foreach (DataRow dr in ds.Tables["Test"].Rows)
                {
                    Console.WriteLine("CustID : " + dr[0] + " Totalamount " + dr[1] + " BillNo " + dr[2]);
                }
            }



        }

        class Product : Program1
        {

            public int Billing()

            {
                SqlConnection con = new SqlConnection("data source =  DESKTOP-6ROTE51; database= task ;user id= sa; password =P@ssword");
                Console.WriteLine("Enter the number of products to be purchased");

                int x = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine("Please choose a product id:");
                    int prodid = Convert.ToInt32(Console.ReadLine());

                    SqlCommand cmd = new SqlCommand("select Price,ProductName from product_table where Productid =" + prodid + "", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    int price = Convert.ToInt32(dr[0]);
                    Console.WriteLine("Enter the  quantity of the product:");
                    int quan = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Item Name: " + dr[1] + "  Quantity: " + quan + "  Price: Rs." + dr[0]);
                    con.Close();

                    price = price * quan;
                    sum += price;

                }

                Console.WriteLine("Total amount is Rs." + sum);


                return sum;
            }
            public int customer()
            {
                Console.WriteLine("Enter the cust Id");
                int cusid = Convert.ToInt32(Console.ReadLine());
                SqlConnection conn = new SqlConnection("Data source =  DESKTOP-6ROTE51; database=task;user id = sa; password =P@ssword");
                SqlDataAdapter da = new SqlDataAdapter("select CustID,Name,City,Gender,Dateofbirth from customertable where CustID= " + cusid + "", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Test");
                foreach (DataRow dr in ds.Tables["Test"].Rows)
                {
                    Console.WriteLine("CustID : " + dr[0] + " Name: " + dr[1] + " City: " + dr[2] + " Gender: " + dr[3] + " Dateofbirth " + dr[4]);
                }
                return cusid;
            }
            public void dateshow1()
            {
                Console.WriteLine("enter the purchase date yyyymmdd");
                int date1 = Convert.ToInt32(Console.ReadLine());
                SqlConnection conn2 = new SqlConnection("Data source =  DESKTOP-6ROTE51; database=task;user id = sa; password =P@ssword");
                SqlDataAdapter dd = new SqlDataAdapter("select CustID,Totalamount,BillNo,purchaseDate from Purchasetable where purchaseDate= " + date1 + "", conn2);
                DataSet ds = new DataSet();
                dd.Fill(ds, "Date");
                foreach (DataRow dr in ds.Tables["Date"].Rows)
                {
                    Console.WriteLine("CustID : " + dr[0] + " Totalamount : " + dr[1] + " BillNo : " + dr[2] + " purchaseDate " + dr[3]);
                }
            }


            public static void Main()
            {
                Product cobj = new Product();
                Console.WriteLine("If you are existing customer enter Y or enter N");
                string sorn = Console.ReadLine();
                switch (sorn)
                {
                    case "Y":
                        cobj.producttable();
                        break;
                    case "N":
                        cobj.insert();
                        break;
                }




                int cusid = cobj.customer();

                int sum = cobj.Billing();
                int Totalamount = sum;
                int CustID = cusid;


                //inserting the return values
                SqlConnection con1 = new SqlConnection("Data source = DESKTOP-6ROTE51; database =task; user id = sa;password = P@ssword");
                Console.WriteLine("enter the purchase date yyyymmdd");
                int purchaseDate = Convert.ToInt32(Console.ReadLine());
                string salqry1 = "insert Purchasetable values( '" + CustID + "','" + Totalamount + "','" + purchaseDate + "')";
                SqlCommand cmd = new SqlCommand(salqry1, con1);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                Console.WriteLine("Row Inserted");
                //purchase table
                Console.WriteLine("Do you need the info of puchase Y or N");
                string pur = Console.ReadLine();
                switch (pur)
                {
                    case "Y":
                        cobj.purchasetable();
                        break;
                    case "N":
                        Console.WriteLine("Visit again thankyou");
                        break;
                }
                Console.WriteLine("Do you need the info under date of purchase Y or N");
                string dat = Console.ReadLine();
                switch (dat)
                {
                    case "Y":
                        cobj.dateshow1();
                        break;
                    case "N":
                        Console.WriteLine("Visit again thankyou");
                        break;
                }

            }
        }
    }
}


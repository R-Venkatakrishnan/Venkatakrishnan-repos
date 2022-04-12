using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Class4
    {
      //  public static void Main()
      //  {
            //  SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51; database = task;user id =sa; password=P@ssword");
            // con.Open();
            //  SqlCommand cmd = new SqlCommand("create table  enroll(sno int,Topic varchar(20))", con);
            //  cmd.ExecuteNonQuery();
            // Console.WriteLine("Completed");
            // con.Close();




            //   SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51; database = task;user id =sa; password=P@ssword");
            //  string sqlqry = "insert enroll values(1,'database')";
            //  con.Open();

            // SqlCommand cmd = new SqlCommand(sqlqry, con);
            //  cmd.ExecuteNonQuery();
            //   Console.WriteLine(" insert Completed");
            //  con.Close();

            // delete
            //     SqlConnection con = new SqlConnection("Data source = DESKTOP-6ROTE51 ; database = task; user id = sa;password = P@ssword");
            //   SqlCommand cmd = new SqlCommand("delete from enroll where sno=1", con);
            //   con.Open();
            // cmd.ExecuteNonQuery();
            // con.Close();

            //update
        //     SqlConnection con = new SqlConnection("Data source = DESKTOP-6ROTE51; database = task;user id =sa; password = P@ssword");
          //  string sqlqry = "update enroll set sno= 2, Topic= 'sql'";
           //  SqlCommand cmd = new SqlCommand(sqlqry, con);
            // con.Open();
            // cmd.ExecuteNonQuery();
            // con.Close();
            // Console.WriteLine("updated Successfully");


            class Day_27_Task
        {
            // SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            public static void Main()
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51;database = Newdatabase;user id = sa ;password = P@ssw0rd");
                con.Open();
                SqlCommand cmd = new SqlCommand("create table newTaskTest (sno int, StuName varchar(20))", con);
                cmd.ExecuteNonQuery();
                int sno;
                sno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Completed Query");
                con.Close();
            }
           // public void insertmeth(int sno, string StuName)
           // {
             //   SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51;database = Newdatabase;user id = sa ;password = P@ssw0rd");
              //  SqlCommand cmd = new SqlCommand("sp_insTask", con);
              //  cmd.CommandType = System.Data.CommandType.StoredProcedure;
              //  cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
              //  cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
               // con.Open();
              //  cmd.ExecuteNonQuery();
               // con.Close();
           // }
            //public void Updatemeth(int sno, string StuName)
            //{

            //    SqlConnection con = new SqlConnection("data source = DESKTOP-6ROTE51;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            //    SqlCommand cmd = new SqlCommand("upd_task", con);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            //    cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //public void deletemeth(int sno)
            //{
            //    SqlConnection con = new SqlConnection("data source =DESKTOP-6ROTE51 ;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            //    SqlCommand cmd = new SqlCommand("del_task", con);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //}
            //public static void Main()
            //{
            //    Day_27_Task nobj = new Day_27_Task();
            //    //nobj.createtable();
            //    Console.WriteLine("Press any Key to Continue....");
            //    Console.ReadLine();
            //    Console.WriteLine("Enter sno");
            //    int sn = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Enter a topic");
            //    //string tpic = Console.ReadLine();
            //    //nobj.insertmeth(sn, tpic);
            //    //nobj.Updatemeth(sn,tpic);
            //    nobj.deletemeth(sn);

            }
        }
    }

}


    }


        }
        
    

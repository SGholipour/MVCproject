using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace layer3_connectionclass
{
  public  class connectionclass
    {
      static string connectionstring = ConfigurationManager.ConnectionStrings["pishtazan university"].ConnectionString;
      public DataSet selectstudent (string Tname,string Tfamily,Int32 Tstdnum,string Taddress,Int32 Ttel,string Tsex,Int32 Tcode) 

      {
          SqlConnection con=new SqlConnection (connectionstring);
          SqlDataAdapter da=new SqlDataAdapter("selectstudent",con);
          da.SelectCommand.CommandType=CommandType.StoredProcedure;
          da.SelectCommand.Parameters.Add("@Tname",SqlDbType.NVarChar).Value=Tname;
          da.SelectCommand.Parameters.Add("@Tfamily",SqlDbType.NVarChar).Value=Tfamily;
          da.SelectCommand.Parameters.Add("@Tstdnum", SqlDbType.Int).Value =Tstdnum;
          da.SelectCommand.Parameters.Add("@Taddress", SqlDbType.NVarChar).Value=Taddress;
          da.SelectCommand.Parameters.Add("@Ttel", SqlDbType.Int).Value = Ttel;
          da.SelectCommand.Parameters.Add("@Tsex",SqlDbType.NVarChar).Value=Tsex;
          da.SelectCommand.Parameters.Add("@Tcode", SqlDbType.Int).Value = Tcode;
          DataSet ds=new DataSet();
          da.Fill(ds,"st");
          return ds;

      }
      public DataSet refreshstudent()
      {
           SqlConnection con=new SqlConnection (connectionstring);
          SqlDataAdapter da=new SqlDataAdapter("refreshstudent",con);
          da.SelectCommand.CommandType=CommandType.StoredProcedure;
          DataSet ds=new DataSet();
          da.Fill(ds,"st");
          return ds;

      }

      public void insertstudent(string Tname, string Tfamily, Int32 Tstdnum, string Taddress, Int32 Ttel, string Tsex, Int32 Tcode)
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("insertstudent", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Tname",SqlDbType.NVarChar).Value=Tname;
          cmd.Parameters.Add("@Tfamily", SqlDbType.NVarChar).Value = Tfamily;
          cmd.Parameters.Add("@Tstdnum", SqlDbType.Int).Value = Tstdnum;
          cmd.Parameters.Add("@Taddress", SqlDbType.NVarChar).Value = Taddress;
          cmd.Parameters.Add("@Ttel", SqlDbType.Int).Value = Ttel;
          cmd.Parameters.Add("@Tsex", SqlDbType.NVarChar).Value = Tsex;
          cmd.Parameters.Add("@Tcode", SqlDbType.Int).Value = Tcode;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
      public void updatestudent(string Tname, string Tfamily, Int32 Tstdnum, string Taddress, Int32 Ttel, string Tsex, Int32 Tcode,Int32 Tid)
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("updatestudent", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Tname", SqlDbType.NVarChar).Value = Tname;
          cmd.Parameters.Add("@Tfamily", SqlDbType.NVarChar).Value = Tfamily;
          cmd.Parameters.Add("@Tstdnum", SqlDbType.Int).Value = Tstdnum;
          cmd.Parameters.Add("@Taddress", SqlDbType.NVarChar).Value = Taddress;
          cmd.Parameters.Add("@Ttel", SqlDbType.Int).Value = Ttel;
          cmd.Parameters.Add("@Tsex", SqlDbType.NVarChar).Value = Tsex;
          cmd.Parameters.Add("@Tcode", SqlDbType.Int).Value = Tcode;
          cmd.Parameters.Add("@Tid", SqlDbType.Int).Value = Tid;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
      public void deletestudent( Int32 Tid)
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("deletestudent", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Tid", SqlDbType.Int).Value = Tid;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
 
      public SqlDataReader login()
      {
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("select Tstdnum,Ttel from student", con);
          cmd.CommandType = CommandType.Text;
         
          SqlDataReader read = cmd.ExecuteReader();
          return read;
      }

      ////دروس
public DataSet selectlessons(Int32 Lcodelesson,Int32 Lcode,string Lname,string Lprofessorname, string Lclasshours) 

      {
          SqlConnection con=new SqlConnection (connectionstring);
          SqlDataAdapter da = new SqlDataAdapter("selectlessons", con);
          da.SelectCommand.CommandType=CommandType.StoredProcedure;
          da.SelectCommand.Parameters.Add("@Lcodelesson", SqlDbType.Int).Value = Lcodelesson;
          da.SelectCommand.Parameters.Add("@Lcode",SqlDbType.Int).Value=Lcode;
          da.SelectCommand.Parameters.Add("@Lname", SqlDbType.NVarChar).Value=Lname;
          da.SelectCommand.Parameters.Add("@Lprofessorname", SqlDbType.NVarChar).Value =Lprofessorname;
          da.SelectCommand.Parameters.Add("@Lclasshours", SqlDbType.NVarChar).Value=Lclasshours;
          DataSet ds=new DataSet();
          da.Fill(ds,"st");
          return ds;

      }
      public DataSet refreshlessons()
      {
           SqlConnection con=new SqlConnection (connectionstring);
           SqlDataAdapter da = new SqlDataAdapter("refreshlessons", con);
          da.SelectCommand.CommandType=CommandType.StoredProcedure;
          DataSet ds=new DataSet();
          da.Fill(ds,"st");
          return ds;

      }

      public void insertlessons(Int32 Lcodelesson, Int32 Lcode, string Lname, string Lprofessorname, string Lclasshours) 
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("insertlessons", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Lcodelesson", SqlDbType.Int).Value =Lcodelesson;
          cmd.Parameters.Add("@Lcode", SqlDbType.Int).Value = Lcode;
          cmd.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lname;
          cmd.Parameters.Add("@Lprofessorname", SqlDbType.NVarChar).Value = Lprofessorname;
          cmd.Parameters.Add("@Lclasshours", SqlDbType.NVarChar).Value = Lclasshours;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
      public void updatelessons(Int32 Lcodelesson, Int32 Lcode, string Lname, string Lprofessorname, string Lclasshours,Int32 Lid) 
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("updatelessons", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Lcodelesson", SqlDbType.Int).Value = Lcodelesson;
          cmd.Parameters.Add("@Lcode", SqlDbType.Int).Value = Lcode;
          cmd.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lname;
          cmd.Parameters.Add("@Lprofessorname", SqlDbType.NVarChar).Value = Lprofessorname;
          cmd.Parameters.Add("@Lclasshours", SqlDbType.NVarChar).Value = Lclasshours;
          cmd.Parameters.Add("@Lid", SqlDbType.Int).Value = Lid;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
      public void deletelessons( Int32 Lid)
      {
          SqlDataReader read;
          SqlConnection con = new SqlConnection(connectionstring);
          con.Open();
          SqlCommand cmd = new SqlCommand("deletelessons", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@Lid", SqlDbType.Int).Value = Lid;
          read = cmd.ExecuteReader();
          read.Close();
          con.Close();

      }
    }
}
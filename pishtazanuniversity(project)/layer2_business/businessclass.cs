using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using layer3_connectionclass;

namespace layer2_business
{
  public  class businessclass
    {

      public DataSet getselectstudent(string Tname, string Tfamily, Int32 Tstdnum, string Taddress, Int32 Ttel, string Tsex,
          Int32 Tcode)
      {
          connectionclass cs = new connectionclass();
          return cs.selectstudent(Tname, Tfamily, Tstdnum, Taddress, Ttel, Tsex, Tcode);

      }

       public DataSet getrefreshstudent()

   {
          connectionclass cs = new connectionclass();
          return cs.refreshstudent();

      }
       public void getinsertstudent(string Tname, string Tfamily, Int32 Tstdnum, string Taddress, Int32 Ttel, string Tsex, Int32 Tcode)
       {
           connectionclass cs = new connectionclass();
           cs.insertstudent(Tname, Tfamily, Tstdnum, Taddress, Ttel, Tsex, Tcode);


       }

        public void getupdatestudent(string Tname, string Tfamily, Int32 Tstdnum, string Taddress, Int32 Ttel, string Tsex, Int32 Tcode,Int32 Tid)
       {
           connectionclass cs = new connectionclass();
           cs.updatestudent(Tname, Tfamily, Tstdnum, Taddress, Ttel, Tsex, Tcode,Tid);


       }
       public void getdeletestudent( Int32 Tid)
        {
            connectionclass cs = new connectionclass();
            cs.deletestudent( Tid);


        }
      //دروس 

       public DataSet getselectlessons(Int32 Lcodelessons, Int32 Lcode, string Lname, string Lprofessorname, string Lclasshours) 
       {
           connectionclass cs = new connectionclass();
           return cs.selectlessons(Lcodelessons, Lcode, Lname, Lprofessorname, Lclasshours);

       }

       public DataSet getrefreshlessons()
       {
           connectionclass cs = new connectionclass();
           return cs.refreshlessons();

       }
       public void getinsertlessons(Int32 Lcodelessons, Int32 Lcode, string Lname, string Lprofessorname, string Lclasshours) 
       {
           connectionclass cs = new connectionclass();
           cs.insertlessons(Lcodelessons, Lcode, Lname, Lprofessorname, Lclasshours);


       }

       public void getupdatelessons(Int32 Lcodelessons, Int32 Lcode, string Lname, string Lprofessorname, string Lclasshours,Int32 Lid)
       {
           connectionclass cs = new connectionclass();
           cs.updatelessons(Lcodelessons, Lcode, Lname, Lprofessorname, Lclasshours, Lid);


       }
       public void getdeletelessons(Int32 Lid)
       {
           connectionclass cs = new connectionclass();
           cs.deletelessons(Lid);


       }

       public SqlDataReader getlogin()
       {
           connectionclass cs = new connectionclass();
           return cs.login();


       }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Q6
    {
        static SqlConnection con;
        static int id;
        public static void Main(string[] args)
        {
            try
            {

                con = new SqlConnection("data source=.; database=Bhuvan; integrated security=SSPI");
                con.Open();
                while (true)
                {
                  lable1:
                  Console.WriteLine("----------Welcome to Comany  management---------- ");
                  Console.WriteLine("1. Enter 1 for show table items ");               
                  Console.WriteLine("2. Enter 2 Exit ");                
                  int acc_var;
                
                    acc_var = Int32.Parse(Console.ReadLine());
                    switch (acc_var)
                    {
                        case 1:                            
                            select_data();                            
                            goto lable1;
                        case 2:
                            Console.WriteLine("Coming out of the database");
                            return;
                            

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Bye");
                con.Close();

                Console.ReadLine();
            }
            Console.Read();
        }
        public static void select_data()
         {
            Console.WriteLine("Enter the id to display the details");
            id = Convert.ToInt32(Console.ReadLine());
            SqlCommand cm = new SqlCommand("Select id,company,branch from Company where id="+id, con);
            SqlDataReader sdr = cm.ExecuteReader();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ID          CompanyName                        Branch      ");
            Console.WriteLine("-----------------------------------------------------------------");

            // Iterating Data  
            while (sdr.Read())
            {

                Console.WriteLine(sdr["id"] + "              " + sdr["company"] + "                 " + sdr["branch"]); // Displaying Record  
            }
            Console.ReadLine();
            Console.Clear();
        }      

    }
}

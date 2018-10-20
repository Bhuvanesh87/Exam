using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace Exam
{
    class Person
    {
        public int age { set; get; }
        public string name { set; get; }
        public override string ToString()
        {
            return string.Format("Name : {0}  \nAge : {1}", name, age);
        }
    }
    class Q3
    {
        static void Main(string[] args)
        {
            string JSONstring = File.ReadAllText(@"F:\\Bizruntime\\prac\\exam\\Exam\\Exam\\JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
             Person p1 = ser.Deserialize<Person>(JSONstring);
             Console.WriteLine(p1);       

            Console.Read();

        }
    }
}

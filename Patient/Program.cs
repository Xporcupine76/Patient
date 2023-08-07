using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Patient
{

    class program
    {

        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.Examine("Jamison");

            Child c = new Child();
            c.Inoculate();
        }


        public class Patient
        {

            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public int weight { get; set; }
            public long ssn { get; set; }

            public void Examine(string pname)
            {

                Console.WriteLine("Examination of " + pname + " completed");

            }
            public void Billing(long ssn)
            {

                Console.WriteLine("Billing completed...");

            }
        }
        public class Child :Patient
        {

            public void Inoculate()
            {

                Console.WriteLine("Chind has been Inoculated");

            }
            
        }
}   }
    
    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Muser
    {
        public Muser() { }
        public Muser(string id, string email, string fname, string lname, string date)
        {
            this.id = id;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.date = date;
        }



        public string id { get; set; }
        public string email { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string  date { get; set; }


        static char[] whitespace = new char[] { ' ', '\t' };
        public static Muser Splituser(string line)
        {
            Muser user=null;
            try
            {
                string[] arr = line.Split(whitespace);
                 user = new Muser(arr[0], arr[1], arr[2], arr[3], arr[4]);
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }

            return user;
        }


        public override string ToString()
        {

            string s = id + " "+email+" "+fname+" "+lname+" "+date;
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Email
{
   class Adduser
    {

       private static StreamWriter wr = new StreamWriter(@"C:\\Users\\Labuser10\\Documents\\ToMic\\Email\\mail.txt",true);
        public static void Add(Muser m)
        {

           
            wr.WriteLine(m.ToString());
            wr.Close();
        }

    }
}

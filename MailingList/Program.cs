using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadList r = new ReadList();
           // r.ReadEmailList("C:\\Users\\Labuser10\\Documents\\ToMic\\Email\\mail.txt");
            Adduser.Add(new Muser("4 "," ikijidj@mail.ru"," aaaa "," vvvv "," 12/10/2015 "));
        }
    }
}

using System;
using System.IO;
namespace Email
{
    class ReadList
    {
        StreamReader file;
        string line;
        
        public void ReadEmailList(string path)
        { 
            file = new StreamReader(path);


            try
            {
                while ((line = file.ReadLine()) != null)
                {

                    Muser mu = Muser.Splituser(line);
                    Console.WriteLine(mu.ToString());

                } file.Close();

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
        }
      
        
    }
}

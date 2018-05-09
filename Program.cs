using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHTTP
{
  class Program
  {
    static void Main(string[] args)
    {
      SimpleHTTPServer myServer = null;
      if (args.Length == 2)
      {
        myServer = new SimpleHTTPServer(args[0], Convert.ToInt32(args[1]));
      }
      

      Console.WriteLine("Server is running on this port: " + myServer.Port.ToString());
      Console.WriteLine("Server Root: " + myServer.RootDirectory);


      while (true)
      {

      }
      //Console.WriteLine("Server is stoping ");

    }
  }
}

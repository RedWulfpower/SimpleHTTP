using System;
using System.IO;

namespace SimpleHTTP
{
  class Program
  {
    static void Main(string[] args)
    {
      SimpleHTTPServer myServer = null;
      if (args.Length == 2)
      {
        Console.WriteLine("Server is running on this port: " + args[1]);
        Console.WriteLine("Server Root: " + args[0]);

        myServer = new SimpleHTTPServer(args[0], Convert.ToInt32(args[1]));
      }
      else if (args.Length == 1)
      {
        Console.WriteLine("Server is running on this port: " + args[0]);
        Console.WriteLine("Server Root: " + Directory.GetCurrentDirectory());

        myServer = new SimpleHTTPServer(Directory.GetCurrentDirectory(), Convert.ToInt32(args[0]));
      }
      else
      {
        Console.WriteLine("Server is running on this port: " + "8080");
        Console.WriteLine("Server Root: " + Directory.GetCurrentDirectory());

        myServer = new SimpleHTTPServer(Directory.GetCurrentDirectory(), 8080);
      }
      //Console.WriteLine("Server is stoping ");

    }
  }
}

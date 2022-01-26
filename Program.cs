using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PathTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            Console.WriteLine("I live in: " + path);
            var home = Environment.GetEnvironmentVariable("HOMEPATH");
            var dirpath = Path.Combine(Environment.GetEnvironmentVariable("HOMEPATH"),".dotnet", "tools");

            var dir = new DirectoryInfo(dirpath);
            var files = dir.GetFiles().Select(x => x.Name).ToList();
            Console.WriteLine("dotnet-tools path:");
            Console.WriteLine(dirpath);
            files.ForEach(x => Console.WriteLine(x));
        }
    }
}

using System;
using System.Diagnostics;
using CCExtensions;

namespace CCTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "1234 3456 1234 5432";
            try
            {
                test.ObfuscateCC();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }
    }
}

using System;
using System.Diagnostics;

namespace ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var myObjectOne = new MyTypeTwo { Enabled = false, Name = "My First Object", Size = 4096 };
            var myObjectTwo = new MyTypeOne { Enabled = true, Name = "My Second Object", Size = 4096 };

            CallMethod(myObjectOne);

            CallMethod(myObjectTwo);

            Console.WriteLine("PFE Challenge !");
        }

        static string CallMethod<T>(T param)
        {
            return param.ToString();
        }



    }
}

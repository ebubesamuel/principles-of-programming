using System;
using System.Text;
using System.Collections.Generic;
namespace Input
{
    public class User
    {
        public User()
        {
        }
        public static int RequestInt(string input)
        {
            try
            {
                System.Console.Write(input);
                return int.Parse(System.Console.ReadLine());

            }

            catch (Exception)
            {
                throw new FormatException("XXX\t INPUT MUST BE A NUMBER \t XXX");
            }

        }
        public static string RequestString(string input)
        {
            try
            {
                System.Console.Write(input);
                return System.Console.ReadLine();
            }

            catch (Exception)
            {
                throw new FormatException("XXX\t INPUT ERROR \tXXX");
            }

        }
    }
}



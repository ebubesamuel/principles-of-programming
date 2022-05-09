using System;
using System.Text;
using System.Collections.Generic;
namespace POP_Assignment1
{
    public class Student : Person
    {
        public Student()
        {
        }
        string FullName => LastName + " " + FirstName;

        public string StudentNumber { get; set; }

        public int Age { get; set; }

        public int Scores { get; set; }

        public int AverageScore { get; set; }

        public string FullAddress { get; set; }

        public Address Address { get; set; }

        public string City { get; set; }


        public override string ToString()
        {
            return ($"Student {FullName} has an average score of {AverageScore} –– Bravo!!\n" +
                    $"Student {FullName} is currently living in {City}\n" +
                    $"Student {FullName} full address is {FullAddress}\n");
        }

    }
}


using System;
using System.Collections.Generic;

namespace POP_Assignment1
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Fill out the following credentials for the student");
            bool inputting = true;
            do
            {
                var student = new Student();
                var address = new Address();


                student.LastName = Input.User.RequestString("Lastname:\t");
                if (string.IsNullOrWhiteSpace(student.LastName))
                {
                    ErrorMessageWhenInputIsEmpty();

                    continue;
                }
                Console.Clear();
                student.FirstName = Input.User.RequestString("FirstName:\t");
                if (string.IsNullOrWhiteSpace(student.FirstName))
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                student.StudentNumber = Input.User.RequestString("Students ID Number:\t");
                if (string.IsNullOrWhiteSpace(student.StudentNumber)) //== null)
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                student.Age = Input.User.RequestInt("Students Age:\t");
                if (student.Age == null)
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }

                Console.Clear();
                address.addressNumber = Input.User.RequestString("Address Number:\t");
                if (string.IsNullOrWhiteSpace(address.addressNumber))
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                address.Street = Input.User.RequestString("Name of Street:\t");
                if (string.IsNullOrWhiteSpace(address.Street))
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                address.City = Input.User.RequestString("Name of City:\t");
                if (string.IsNullOrWhiteSpace(address.City))
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                address.Country = Input.User.RequestString("Name of Country:\t");
                if (string.IsNullOrWhiteSpace(address.Country))
                {
                    ErrorMessageWhenInputIsEmpty();
                    continue;
                }
                Console.Clear();
                student.FullAddress = address.FullAddress;
                student.City = address.City;

                int noOfSemestersDone = Input.User.RequestInt("Input the number of semesters the student complete? :\t");
                Console.WriteLine($"Compute the scores obtained by the student in the {noOfSemestersDone} semesters completed");
                Console.Clear();

                int[] ArrOfScore = new int[noOfSemestersDone];
                for (int i = 0; i < noOfSemestersDone; i++)
                {
                    Console.Write($"The score for semester {i + 1} is? :");
                    ArrOfScore[i] = int.Parse(Console.ReadLine());//int.Parse(Console.ReadLine());
                }
                Console.Clear();
                int addScores = 0;
                int averageofScores = 0;

                for (int i = 0; i < noOfSemestersDone; i++)
                {
                    addScores = addScores + ArrOfScore[i];

                }

                averageofScores = addScores / noOfSemestersDone;

                student.AverageScore = averageofScores;


                Console.WriteLine();
                Console.WriteLine("XXX \tStudents Information Displayed\t XXX");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(student.ToString());

                break;

            }


            while (inputting);




        }

        public static void ErrorMessageWhenInputIsEmpty()
        {
            Console.WriteLine("Please ty again, the field cannot be left empty");
        }
    }
}

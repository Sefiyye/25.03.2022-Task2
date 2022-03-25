using System;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            string groupNo;

            do
            {
                Console.Write("Enter your FullName please: ");
                fullName = Console.ReadLine();
            }
            while (!Student.CheckFullname(fullName));

            do
            {
                Console.Write("Enter your Group please: ");
                groupNo = Console.ReadLine();
            }
            while (!Student.CheckGroupNo(groupNo));

            Console.Write("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("~~~~~~~~~~~~~~~");

            Student student = new Student(fullName, groupNo, age);
            student.Info();

        }
    }
}
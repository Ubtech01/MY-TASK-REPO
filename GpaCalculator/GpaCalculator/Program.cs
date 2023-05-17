using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GpaCalculator
{
    public class Program
    {
        string courseCode;
        int courseUnit;
        int course;
        char grade;
        int gradeUnit;
        double weightPoint;
        string remark;
        int score;
        string Storage;
        string TotalcourseUnit;
        int totalCourseUnitRegistered;
        int totalCourseUnitpassed = 0;
        double totalWeightPoint;
        double gpa;
        public void Solvings()
        {
            Console.WriteLine("WELCOME TO YOUR GPA CALCULATOR\n");

            //Ask for user's course offered
            Console.WriteLine("Enter number of courses: ");
            course = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            for (int i = 0; i < course; i++)
            {
                //User's course title
                Console.WriteLine("Enter course title: ");
                courseCode = Console.ReadLine();

                //User's course unit
                Console.WriteLine("Enter course unit: ");
                courseUnit = Convert.ToInt32(Console.ReadLine());

                //User's course score
                Console.WriteLine("Enter course score: ");
                score = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                //User's score requirement
                grade = score >= 70 ? 'A' : score >= 60 ? 'B' : score >= 50 ? 'C' : score >= 45 ? 'D' : score >= 40 ? 'E' : 'F';
                gradeUnit = score >= 70 ? 5 : score >= 60 ? 4 : score >= 50 ? 3 : score >= 45 ? 2 : score >= 40 ? 1 : 0;
                weightPoint = gradeUnit * courseUnit;
                remark = grade == 'A' ? "Excellent" : grade == 'B' ? "Very Good" : grade == 'C' ? "Good" : grade == 'D' ? "Fair" : grade == 'E' ? "Pass" : "Fail";

                Storage += $"|{courseCode,-11}|{courseUnit,-14}|{grade,-13}|{gradeUnit,-11} |{weightPoint,-13}|{remark,-12}|\n";

                totalCourseUnitRegistered += courseUnit;
                if (grade != 'F')
                {
                    totalCourseUnitpassed += courseUnit;
                }
                
                totalWeightPoint += weightPoint;
                gpa = totalWeightPoint / totalCourseUnitRegistered;
            }
            Console.WriteLine("GPA TABLE.................................\n");
            Console.WriteLine("|-----------|--------------|-------------|------------|-------------|------------|");
            Console.WriteLine("|COURSE&CODE|  COURSE UNIT |    GRADE    | GRADE UNIT |   WEIGHT PT |  REMARK    |");
            Console.WriteLine("|-----------|--------------|-------------|------------|-------------|------------|");
            Console.WriteLine(Storage);
            Console.WriteLine($"Total Course Unit Registered is : {totalCourseUnitRegistered}");
            Console.WriteLine($"Total Course Unit Passed is : {totalCourseUnitpassed}");
            Console.WriteLine($"Total Weight Point is : {totalWeightPoint}");
            Console.WriteLine($"Your GPA is {gpa:F2}");
            Console.ReadKey();

        }
        public static void Main(string[] args)
        {
            Program ubong = new Program();
            ubong.Solvings();
        }
    }
}


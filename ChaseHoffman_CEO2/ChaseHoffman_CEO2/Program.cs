using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu.display();
            string titleResponse;
            string teacherName;
            Person currentPerson = new Person();
            Course currentCourse = new Course();

            //Define Teachers age
            currentPerson.Age = 30;

            string menuResponse = Console.ReadLine();
            while (menuResponse != "1" && menuResponse != "2" && menuResponse != "3" && menuResponse != "4" && menuResponse != "0" && menuResponse.ToLower() != "create course" && menuResponse.ToLower() != "create teacher" && menuResponse.ToLower() != "add student" && menuResponse.ToLower() != "display information" && menuResponse.ToLower() != "exit")
            {
                Console.WriteLine("Please enter a valid menu choice!");
                menuResponse = Console.ReadLine();
            }


            int menuHolder = 1;
            while (menuHolder == 1)
            {
                if (menuResponse == "1" || menuResponse.ToLower() == "create course")
                {
                    //Course Title
                    Console.WriteLine("Please enter your course title...");
                    titleResponse = Console.ReadLine();
                    titleResponse = Validation.ValidateString(titleResponse);

                    //Teachers Name
                    Teacher currentTeacher = new Teacher();
                    Console.WriteLine("What is your teachers name?");
                    string teacherName = Console.ReadLine();
                    teacherName = Validation.ValidateString(teacherName);
                    currentTeacher.Name = teacherName;

                    //Number of students
                    Console.WriteLine("Please insert the amount of students in the class...");
                    string classAmount = Console.ReadLine();
                    int classSize = Validation.ValidateInt(classAmount);
                    Student[] cSize = new Student[classSize];

                    //Create the course
                    Course currentCourse = new Course(titleResponse, currentTeacher, cSize);
                }
                else if (menuResponse == "2" || menuResponse.ToLower() == "create teacher")
                {
                    //Get length of array
                    Console.WriteLine("How many entries are in your teachers Education brackground?");
                    string sbge = Console.ReadLine();
                    int backgroundLength = Validation.ValidateInt(sbge);

                    //define the array
                    string[] backgroundEducation = new string[backgroundLength];

                    //populate array with information
                    Console.WriteLine($"Please enter your {backgroundLength} background entries...");
                    for (int i = 0; i<backgroundLength; i++)
                    {
                        backgroundEducation[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Thank you for providing us with that information.");
                    Current
                }
                else if (menuResponse == "3" || menuResponse.ToLower() == "add student")
                {
                    Console.WriteLine("CHOICE 3");
                }
                else if (menuResponse == "4" || menuResponse.ToLower() == "display information")
                {
                    Console.WriteLine("CHOICE 4");
                }
                else if (menuResponse == "0" || menuResponse.ToLower() == "exit") ;
                {
                    Environment.Exit(0);
                    Console.WriteLine("CHOICE 0");
                }
                
                Menu.display();
                menuResponse = Console.ReadLine();
            }
        }
    }
}

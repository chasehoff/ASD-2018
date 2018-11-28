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
            string titleResponse = "Math";
            string teacherName = "Carl";
            int grade = 100;
            int age = 30;
            int backgroundLength = 0;
            Course displayCourse = new Course(null, null, null);
            Teacher teacher = new Teacher(null, null, age);
            Person currentPerson = new Person(teacherName, age);
            Student students = new Student(grade, null, age);

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
                    displayCourse.courseTitle = titleResponse;

                    //Teachers Name
                    Teacher currentTeacher = new Teacher(null, teacherName, age);
                    Console.WriteLine("What is your teachers name?");
                    teacherName = Console.ReadLine();
                    teacherName = Validation.ValidateString(teacherName);
                    currentTeacher.Name = teacherName;

                    //Number of students
                    Console.WriteLine("Please insert the amount of students in the class...");
                    string classAmount = Console.ReadLine();
                    int classSize = Validation.ValidateInt(classAmount);
                    Student[] cSize = new Student[classSize];

                    //Create the course
                    Course newCourse = new Course(titleResponse, currentTeacher, cSize);
                    
                }
                else if (menuResponse == "2" || menuResponse.ToLower() == "create teacher")
                {
                    //Get length of array
                    Console.WriteLine("How many entries are in your teachers Education brackground?");
                    string sbge = Console.ReadLine();
                    backgroundLength = Validation.ValidateInt(sbge);

                    //define the array
                    string[] backgroundEducation = new string[backgroundLength];

                    //populate array with information
                    Console.WriteLine($"Please enter your {backgroundLength} background entries...");
                    for (int i = 0; i<backgroundLength; i++)
                    {
                        backgroundEducation[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Thank you for providing us with that information.");
                    Teacher newTeacher = new Teacher(backgroundEducation, teacherName, age);
                }
                else if (menuResponse == "3" || menuResponse.ToLower() == "add student")
                {
                   
                    if (backgroundLength == 0)
                    {
                        Console.WriteLine("Please type in the number of students in your course...");
                        string studentHolder = Console.ReadLine();

                        backgroundLength = Validation.ValidateInt(studentHolder);
                    }
                    Student[] studentList = new Student[backgroundLength];
                    //name holder temp
                    string nh;
                    //age holder temp
                    string sah;
                    for (int i = 0; i<backgroundLength; i++)
                    {
                        //get name
                        Console.WriteLine($"What is your #{i+1} students name?");
                        nh = Console.ReadLine();
                        string name = Validation.ValidateString(nh);

                        //get age
                        Console.WriteLine($"What is your students age?");
                        sah = Console.ReadLine();
                        int Age = Validation.ValidateInt(sah);

                        //Get grade
                        Console.WriteLine($"What is the students grade?");
                        string gradeph = Console.ReadLine();
                        grade = Validation.ValidateInt(gradeph);

                        //Create the new student
                        Student newStudent = new Student(grade, nh, age);
                    }
                }
                else if (menuResponse == "4" || menuResponse.ToLower() == "display information")
                {
                    Console.WriteLine($"Course Name: {titleResponse}" +
                        $"\r\nTeacher: {teacherName}");

                    Console.ReadKey();
                }
                else if (menuResponse == "0" || menuResponse.ToLower() == "exit")
                {
                    Environment.Exit(0);
                    Console.WriteLine("CHOICE 0");
                }
                Console.Clear();
                Menu.display();
                menuResponse = Console.ReadLine();
            }
        }
    }
}

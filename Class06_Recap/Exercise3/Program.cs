using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution1();
            Solution2();
        }

        public static void Solution1() 
        {
            Student marko = new Student("Marko", "SEDC", "G1");
            Student maja = new Student("Maja", "SEDC", "G2");
            Student ivo = new Student("Ivo", "SEDC", "G3");
            Student angela = new Student("Angela", "SEDC", "G1");
            Student slavko = new Student("Slavko", "SEDC", "G1");

            Student[] studentList = new Student[5];
            studentList[0] = angela;
            studentList[1] = ivo;
            studentList[3] = maja;
            studentList[2] = slavko;
            studentList[4] = marko;

            string inputName = Console.ReadLine();
            foreach (var student in studentList)
            {
                if (student.Name.ToLower() == inputName.ToLower())
                {
                    Console.WriteLine($"{student.Name}, {student.Group}, {student.Academy}");
                    return;
                }

            }

            Console.WriteLine("Error!");
        }

        public static void Solution2() 
        {
            Student marko = new Student("Marko", "SEDC", "G1");
            Student maja = new Student("Maja", "SEDC", "G2");
            Student ivo = new Student("Ivo", "SEDC", "G3");
            Student angela = new Student("Angela", "SEDC", "G1");
            Student slavko = new Student("Slavko", "SEDC", "G1");

            Student[] studentList = new Student[5];
            studentList[0] = angela;
            studentList[1] = ivo;
            studentList[3] = maja;
            studentList[2] = slavko;
            studentList[4] = marko;

            while (true) 
            {
                Console.Write("Please enter a student name: ");
                string inputName = Console.ReadLine();

                bool isStudentFound = false;
                Student studentToDisplay = new Student();

                while (true) 
                {
                    foreach (var student in studentList)
                    {
                        if (student.Name.ToLower() == inputName.ToLower())
                        {
                            isStudentFound = true;
                            studentToDisplay.Name = student.Name;
                            studentToDisplay.Academy = student.Academy;
                            studentToDisplay.Group = student.Group;
                            break;
                        }
                    }

                    if (isStudentFound)
                    {
                        Console.WriteLine($"{studentToDisplay.Name}, {studentToDisplay.Group}, {studentToDisplay.Academy}");
                        isStudentFound = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        isStudentFound = false;
                        break;
                    }
                }
            }
        }
    }
}

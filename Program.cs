using System;
using System.Collections.Generic;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons
}
namespace Homework1
{
    class Program
    {
        static PersonList personList;


        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintScreenMenu();

            static void PreparePersonListWhenProgramIsLoad()
            {
                Program.personList = new PersonList();
            }

            static void PrintScreenMenu()
            {
                Console.Clear();
                PrintHeader();
                PrintListMenu();
                InputMenuFromKeyboard();
            }
            static void PrintHeader()
             {
                Console.WriteLine("Welcome to registration new user school application.");
                Console.WriteLine("----------------------------------------------------");
             }
            static void PrintListMenu()
            {
                Console.WriteLine("1. Register new student.");
                Console.WriteLine("2. Register new teacher.");
                Console.WriteLine("Get List Persons..");
            }
            static void InputMenuFromKeyboard()
            {
                Console.Write("Please Select Menu:");
                Menu menu = (Menu)(int.Parse(Console.ReadLine()));

                PresentMenu(menu);
            }
            static void PresentMenu(Menu menu)
            {
                if (menu == Menu.RegisterNewStudent)
                {
                    ShowInputRegisterNewStudentScreen();
                }else if (menu == Menu.RegisterNewTeacher)
                {
                    ShowInputRegisterNewTeacherScreen();
                }else if (mnenu == Menu.GetListPersons)
                {
                    ShowGetListsPersonScreen();
                }
                else 
                {
                    ShowMessageInputIsIncorrect();
                }
            }

            static void ShowGetListsPersonScreen()
            {
                Console.Clear();
                Program.personList.FetchPersonList();
                inputExitFromKeyboard();
            }

            static voud InputExitFromKeyvoard()
            {
                string text = "";
                while(text != "exit")
                {
                    Console.Write("input: ");
                    text = Console.ReadLine();

                }
                Console.Clear();
                PrintScreenMenu();
            }

            static void ShowInputRegisterNewTeacherScreen()
            {
                Console.Clear();

                int totalTeacher = TotalTeacher();

                InputNewTeacherFromKeyboard(totalTeacher);
            }

            static int TotalTeacher()
            {
                Console.Write("Input total new teacher: ");
                return int.Parse(Console.ReadLine());
            }

            static void InputNewTeacherFromKeyboard(int totalTeacher)
            {
                for (uint = 0; int < totalTeacher; int++)
                {
                    Console.Clear();
                    PrintHeaderRegisterTeacher();

                    Teacher teacher = CreateNewTeacher();

                    Program.personList.AddNewPerson(teacher);
                }
                Console.Clear();
                PrintScreenMenu();
            }

            static void ShowInputRegisterNewStudentScreen()
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                int totalStudent = TotalNewStudent();

                InputNewStudentFromKeyboard(totalStudent);
            }

            static void InputNewStudentFromKeyboard(int totalStudent)
            {
                for (int i = 0; i < totalStudent; i++)
                {
                    Console.Clear();
                    PrintHeaderRegisterStudent();

                    Student student = CreateNewStudent();

                    Program.personList.AddNewPerson(student);
                }
                Console.Clear();
                PrintScreenMenu();
            }

            static void CreateNewTeacher()
            {
                retuen new Teacher(InputName), InputAddress(), InputCitizenID(), InputEmployeeID();
            }

            static void CreateNewStudent()
            {
                return new Student(InputName(), InputAddress();, InputCitizenID();, InputStudentID();
            }

            static string InputName()
            {
                Console.Write("Name: ");
                return Console.ReadLine();
            }

            static string InputStudentID()
            {
                Console.Write("Student ID: ");
                return Console.ReadLine();
            }

            static string InputEmployeeID()
            {
                Console.Write("Employee ID: ");
                return Console.ReadLine();
            }

            static string InputAddress()
            {
                Console.Write("Address: ");
                return Console.ReadLine();
            }

            static string InputCitizenID()
            {
                Console.Write("Citizen ID: ");
                return Console.ReadLine();
            }

            static int TotalNewStudent()
            {
                Console.WriteLine("Input total new student.");

                return int.Parse(Console.ReadLine());
                
            }

            static void PrintHeaderRegisterStudent()
            {
                Console.WriteLine("Register new student.");
                Console.WriteLine("---------------------");
            }

            static void PrintHeaderRegisterTeacher()
            {
                Console.WriteLine("Register new teacher.");
                Console.WriteLine("---------------------");
            }

            static void ShowMessageInputIsIncorrect()
            {
                Console.Clear();
                Console.WriteLine("Menu is incorrect. Please try again.");
                InputMenuFromKeyboard();
            }
        }
    }
    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;

        public Person(string name,string address,string citizenID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
        }
        public string GetName()
        {
            return this.name;
        }
    }

    class Student : Person
    {
        private string studentID;

        public Student(string name,string address,string citizenID,string studentID) : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
    }

    class Teacher : Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID) : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }
    }

    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }
        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
        public void FetchPersonList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("------------");
            foreach(Person person in this.personList)
            {
                if(person is Student)
                {
                    Console.WriteLine("Name: {0} \n Type: Student", person.GetName());
                }else if (person is Teacher)
                {
                   Console.WriteLine("Name: {0} \n Type: Teacher", person.GetName());
                }
            }
        }
    }
}

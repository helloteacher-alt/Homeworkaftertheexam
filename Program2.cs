using System;
using System.Collections.Generic;

namespace HomeworkNo2
{
    class Program
    {
        enum Menu
        {
            Login=1,RegisterStudent,RegisterTeacher,Exit
        }
        enum ActivityMenu
        {
            ActivityList=1,Exit
        }
        enum ActivityList
        {
            Join=1,Exit
        }

        static PersonList personList;
        static void Main(string[] args)
        {
            PreparePersonList();
            PrintMenuScreen();
        }

        static void PreparePersonList()
        {
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeaderWelcomeText();
            PrintMenu();
        }

        static void PrintHeaderWelcomeText()
        {
            Console.WriteLine("Welcome to Student Activity");
            Console.WriteLine(" ");
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register student");
            Console.WriteLine("3. Register teacher");
            Console.WriteLine("4. Exit ");
            InputKeyFromKeyboard();
        }

        static void InputKeyFromKeyboard()
        {
            Console.Write("Please select menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            ShowMenu(menu);
        }

        static void ShowMenu(Menu menu)
        {
            if (menu == Menu.Login)
            {
                ShowLoginScreen();
            }
            else if (menu == Menu.RegisterStudent)
            {
                ShowRegisterStudentScreen();
            }else if (menu == Menu.RegisterTeacher)
            {
                ShowRegisterTeacherScreen();
            }
            else if (menu == Menu.Exit)
            {
                ShowExitMenu();
            }
            else PrintErrorText();
        }

        static void ShowLoginScreen()
        {
            Console.Clear();
            PrintLoginHeader();

            InputLoginInformation();
        }

        static void InputLoginInformation()
        {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input password:");
            string password = Console.ReadLine();
            PrintActivityMenu();
        }

        static void PrintActivityMenu()
        {
            Console.Clear();
            PrintActivityMenuHeader();
            PrintListMenuActivity();
        }

        static void PrintListMenuActivity()
        {
            Console.WriteLine("1. Activity List");
            Console.WriteLine("2. Exit");
            PrintSelectMenuActivityFromKeyboard();
        }

        static void PrintSelectMenuActivityFromKeyboard()
        {
            Console.Write("Please select menu: ");
            ActivityMenu activitymenu = (ActivityMenu)(int.Parse(Console.ReadLine()));
            ShowActivity(activitymenu);
        }

        static void ShowActivity(ActivityMenu activitymenu)
        {
            if (activitymenu == ActivityMenu.ActivityList)
            {
                ShowActivityList();
            }else if (activitymenu == ActivityMenu.Exit)
            {
                ShowExitMenu();
            }else PrintErrorActivityText();
        }

        static void ShowActivityList()
        {
            Console.Clear();
            ShowActivityList2();
            Console.WriteLine("Choices for you");
            Console.WriteLine("1. Join the activity.");
            Console.WriteLine("2. Exit.");
            PrintSelectActivityMenuFromKeyboard();
        }

        static void PrintSelectActivityMenuFromKeyboard()
        {
            Console.Write("Select menu: ");
            ActivityList activitylist = (ActivityList)(int.Parse(Console.ReadLine()));
            ShowJoinActivityScreen(activitylist);
        }

        static void ShowJoinActivityScreen(ActivityList activitylist)
        {
            if (activitylist == ActivityList.Join)
            {
                ShowJoinActivityScreen();
            }
            else if (activitylist == ActivityList.Exit)
            {
                ShowExitMenu();
            }
            else PrintErrorActivityText();
        }

        static void ShowJoinActivityScreen()
        {
            Console.Clear();
            ShowActivityList2();
            Console.WriteLine("You only have the right to choose 1 activity in this semester.");
            Console.Write("Input number of your activity: ");
            Console.ReadLine();
            PrintEndText();
            PrintExit();
        }

        static void PrintExit()
        {
            string text = "";
            while (text != "exit")
            {
                Console.Write("Enter the word 'exit' for log out:");
                text=Console.ReadLine();
            }
            Console.Clear();
        }

        static void PrintEndText()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------");
            Console.WriteLine("We have received your request. It will take up to 3 days for verification.");
        }

        static void ShowActivityList2()
        {
            Console.WriteLine("Activity list");
            Console.WriteLine("");
            Console.WriteLine("1. Bake Cookies");
            Console.WriteLine("2. Try a new food from around the world");
            Console.WriteLine("3. Learn a new Language (Spanish/Portuguese/Russian)");
            Console.WriteLine("4. Arts and Craft");
            Console.WriteLine("5. Herb Garden");
            Console.WriteLine("6. Homemade Pizzas");
            Console.WriteLine("7. 24 hrs without internet");
            Console.WriteLine("8. Magic trick");
            Console.WriteLine("");
            Console.WriteLine("--------------");
        }

        static void PrintErrorActivityText()
        {
            Console.WriteLine("Incorrect. Please try again.");
            PrintListMenuActivity();
        }

        static void PrintActivityMenuHeader()
        {
            Console.WriteLine("Home menu");
        }

        static void ShowRegisterStudentScreen()
        {
            Console.Clear();
            PrintRegisterHeader();

            InputNewStudentFormKeyboard();
        }

        static void ShowRegisterTeacherScreen()
        {
            Console.Clear();
            PrintRegisterHeader();

            InputNewTeacherFromKeyboard();
        }

        static void InputNewTeacherFromKeyboard()
        {
            Teacher teacher = CreateNewTeacher();
            Program.personList.AddNewPerson(teacher);
            PrintMenuScreen();
        }

        static void InputNewStudentFormKeyboard()
        {
            Student student = CreateNewStudent();
            Program.personList.AddNewPerson(student);
            PrintMenuScreen();
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(), InputCitizenID(), InputTeacherID(),InputPassword());
        }

        static Student CreateNewStudent()
        {
            return new Student (InputName(), InputCitizenID(), InputStudentID(),InputPassword());
        }

        static string InputPassword()
        {
            Console.Write("Input password: ");
            return Console.ReadLine();
        }
        static string InputName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }
        static string InputCitizenID()
        {
            Console.Write("CitizenID: ");
            return Console.ReadLine();
        }
        static string InputStudentID()
        {
            Console.Write("Input StudentID: ");
            return Console.ReadLine();
        }
        static string InputTeacherID()
        {
            Console.WriteLine("Input TeacherID: ");
            return Console.ReadLine();
        }

        static void PrintRegisterHeader()
        {
            Console.WriteLine("Register");
        }

        static void ShowExitMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Input the word 'exit' if you want to leave \nInput 'menu' for turn back to menu screen");
            Console.Write("Input word: ");
            string text = Console.ReadLine();
            if (text == "exit")
            {

            }else if (text == "menu")
            {
                PrintMenuScreen();
            }
        }

        static void PrintLoginHeader()
        {
            Console.WriteLine("Login");
        }

        static void PrintErrorText()
        {
            Console.WriteLine("Incorrect number. Please try again");
            PrintMenu();
        }
    }

    class Person
    {
        protected string name;
        protected string citizenID;
        protected string password;
        public Person(string name,string citizenID,string password)
        {
            this.name = name;
            this.citizenID = citizenID;
            this.password = password;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }

    class Student : Person
    {
        private string studentID;
        public Student(string name,string citizenID,string studentID,string password) : base(name, citizenID,password)
        {
            this.studentID = studentID;
        }
        public string GetStudentID()
        {
            return this.studentID;
        }
    }

    class Teacher : Person
    {
        private string teacherID;
        public Teacher(string name, string citizenID, string teacherID,string password) : base(name, citizenID,password)
        {
            this.teacherID = teacherID;
        }
        public string GetTeachertID()
        {
            return this.teacherID;
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
        public void CheckpersonList()
        {
            foreach(Person person in this.personList)
            {
                if(person is Student)
                {
                    Console.WriteLine("Name:",person.GetName());
                }else if (person is Teacher)
                {
                    Console.WriteLine("Name:", person.GetName());
                }
            }
        }
    }
}

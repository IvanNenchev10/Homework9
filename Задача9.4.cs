using System;

namespace Task9._2
{
    class Program
    {
        abstract class Person
        {
            protected string name;
            protected string family;
            protected int experience;
            public Person()
            {
                name = null;
                family = null;
                experience = 0;
            }
            public Person(string name,string family,int experience)
            {
                this.name = name;
                this.family = family;
                this.experience = experience;
            }
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            public string Family
            {
                set { family = value; }
                get { return family; }
            }
            public int Experience
            {
                set { experience = value; }
                get
                {
                    try
                    {
                        if(experience<0)
                        {
                            throw new FormatException("Experience should be positive number");
                           
                        }
                        return experience;
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("{0}", e.Message);
                        return -1;
                    }
                }
            }
            public abstract void sayGoodAfternoon();
            public abstract void CheckHomework();
            public static int NumberOfInstances(int counter)
            {
                return counter;
            }
        }
        class Teacher : Person
        {
           protected string subject;
            public Teacher()
            {
                subject = null;
            }
            public Teacher(string subject, string name, string family, int experience) : base(name, family, experience)
            {
                this.subject = subject;
            }
            public string Subject
            {
                set { subject = value; }
                get { return subject; }
            }
            public override  void sayGoodAfternoon()
            {
                Console.WriteLine("Teacher says good afternoon");
            }
            public override  void CheckHomework()
            {
                Console.WriteLine("Teacher checks homework");
            }
            public void sayGoodBye()
            {
                Console.WriteLine("Teacher says Goodbye");
            }
        }
        class Lecturer : Person
        {
            protected string university;
            public const int lectures = 10;
            public Lecturer()
            {
                university = null;
            }
            public Lecturer(string university,string name,string family,int experience):base(name,family,experience)
            {
                this.university = university;
            }
            public string University
            {
                set { university = value; }
                get { return university; }
            }
            public int Lectures
            {
                get
                {
                    return lectures;
                }
            }
            public override void sayGoodAfternoon()
            {
                Console.WriteLine("Lecturer says Good Afternoon");
            }
            public override void CheckHomework()
            {
                Console.WriteLine("Lecturer checks Homework");
            }
            public void Exercise(string subject)
            {
                Console.WriteLine("We have {0} on Monday", subject);
            }
            public void Exercise(string subject,string subject1)
            {
                Console.WriteLine("We have {0} and {1} on Wednesday", subject, subject1);
            }
            public void Exercise(string subject,string subject1,string subject2)
            {
                Console.WriteLine("We have {0},{1} and {2} on Friday",subject,subject1,subject2);
            }
        }
        class Professor:Lecturer
        {
            private string title;
            public Professor()
            {
                title = null;
            }
            public Professor(string title,string university,string name,string family,int experience):base(university,name,family,experience)
            {
                this.title = title;
            }
            public string Title
            {
                set { title = value; }
                get { return title; }
            }
            public void GetTitle()
            {
                Console.WriteLine("My title is:{0}", Title);
                Console.WriteLine("I have {0} years of experience", Experience);
            }
            public void HoldExam()
            {
                Console.WriteLine("Professor holds exam");
            }
            public override void CheckHomework()
            {
                Console.WriteLine("Professor checks Homework");
            }
        }
        class Assistant:Lecturer
        {
            private bool isMainAssistant;
            public Assistant()
            {
                isMainAssistant = false;
            }
            public Assistant(bool isMainAssistant,string university,string name,string family,int experience):base(university,name,family,experience)
            {
                this.isMainAssistant = isMainAssistant;
            }
            public bool IsMainAssistant
            {
                set { isMainAssistant = value; }
                get { return isMainAssistant; }
            }
            public void CheckAssistant()
            {
                if(isMainAssistant==true)
                {
                    Console.WriteLine("My name is {0} and I am main assistant",Name);
                }
                else
                {
                    Console.WriteLine("My name is {0} and I am not main assistant", Name);
                }
            }
            public override void CheckHomework()
            {
                Console.WriteLine("Assistant checks Homework");
            }
            public void CheckExam()
            {
                Console.WriteLine("Assistant checks exam");
            }
            public void Write()
            {
                Console.WriteLine("Assistant writes scientific articles");
            }
        }
        class SchoolTeacher:Teacher
        {
            private string[] classes;
            public const int size = 5;
            public SchoolTeacher()
            {
                classes = null;
            }
            public SchoolTeacher(string subject,string name,string family,int experience):base(subject,name,family,experience)
            {
                classes = new string[size];
                for(int i=0;i<size;i++)
                {
                    Console.WriteLine("Enter class {0}", i + 1);
                    classes[i] = Console.ReadLine();
                }
            }
            public void PrintClasses()
            {
                for(int i=0;i<size;i++)
                {
                    Console.Write("{0} ", classes[i]);
                }
            }
            public void EntertainChildren()
            {
                Console.WriteLine("School Teacher entertains children");
            }
            public override void CheckHomework()
            {
                base.CheckHomework();
            }
        }
        class CollegeTeacher:Teacher
        {
            private string college;
            public CollegeTeacher()
            {
                college = null;
            }
            public CollegeTeacher(string college,string subject,string name,string family,int experience):base(subject,name,family,experience)
            {
                this.college = college;
            }
            public string College
            {
                set { college = value; }
                get { return college; }
            }
            public override void CheckHomework()
            {
                base.CheckHomework();
            }
        }
        static void Main()
        {
            Person p;
            int counter = 0;
            Teacher Mathteacher = new Teacher("Mathematics", "Petar", "Ivanov", 10);
            p = Mathteacher;
            counter++;
            Console.WriteLine("MathTeacher Name:{0}", p.Name);
            Console.WriteLine("MathTeacher Family:{0}", p.Family);
            Console.WriteLine("MathTeacher Experience:{0} years", p.Experience);
            Console.WriteLine("MathTeacher Subject:{0}", Mathteacher.Subject);
            p.sayGoodAfternoon();
            p.CheckHomework();
            Mathteacher.sayGoodBye();
            Lecturer Historylecturer = new Lecturer("Paisii Hilendarski", "Anton", "Georgiev", 15);
            p = Historylecturer;
            counter++;
            Console.WriteLine();
            Console.WriteLine("HistoryLecturer Name:{0}", p.Name);
            Console.WriteLine("HistoryLecturer Family:{0}", p.Family);
            Console.WriteLine("HistoryLecturer Experience:{0} years", p.Experience);
            Console.WriteLine("HistoryLecturer University:{0}", Historylecturer.University);
            p.sayGoodAfternoon();
            p.CheckHomework();
            Console.WriteLine("Number of Lectures:{0}", Historylecturer.Lectures);
            Historylecturer.Exercise("History");
            Historylecturer.Exercise("History", "HistorySeminar");
            Historylecturer.Exercise("History", "HistorySeminar", "ExtraTimeHistoryClass");
            Professor Biologyprofessor = new Professor("Professor", "Kliment Ohridski", "Georgi", "Georgiev", 17);
            p = Biologyprofessor;
            counter++;
            Console.WriteLine();
            Console.WriteLine("BiologyProfessor Name:{0}", p.Name);
            Console.WriteLine("BiologyProfessor Family:{0}", p.Name);
            Console.WriteLine("BiologyProfessor Experience:{0}", p.Experience);
            Console.WriteLine("BiologyProfessor University:{0}", Biologyprofessor.University);
            Console.WriteLine("BiologyProfessor Title:{0}", Biologyprofessor.Title);
            p.CheckHomework();
            Biologyprofessor.HoldExam();
            Assistant Biologyassistant = new Assistant(true, "Kliment Ohridski", "Ivan", "Ivanov", 5);
            p = Biologyassistant;
            counter++;
            Console.WriteLine();
            Console.WriteLine("Biology Assistant Name:{0}", p.Name);
            Console.WriteLine("Biology Assistant Family:{0}", p.Family);
            Console.WriteLine("Biology Assistant Experience:{0}", p.Experience);
            Console.WriteLine("Biology Assistant University:{0}", Biologyassistant.University);
            Console.WriteLine("Biology Assistant Is Main Assistant:{0}", Biologyassistant.IsMainAssistant);
            Biologyassistant.CheckAssistant();
            p.CheckHomework();
            Biologyassistant.CheckExam();
            Biologyassistant.Write();
            SchoolTeacher Schoolteacher = new SchoolTeacher("Geography", "Nikolay", "Georgiev", 7);
            p = Schoolteacher;
            counter++;
            Console.WriteLine();
            Console.WriteLine("School Teacher Name:{0}", p.Name);
            Console.WriteLine("School Teacher Family:{0}", p.Family);
            Console.WriteLine("School Teacher Experience:{0}", p.Experience);
            Console.WriteLine("School Teacher Subject:{0}", Schoolteacher.Subject);
            p.CheckHomework();
            Console.WriteLine("Classes are:");
            Schoolteacher.PrintClasses();
            Console.WriteLine();
            Schoolteacher.EntertainChildren();
            CollegeTeacher Collegeteacher = new CollegeTeacher("Cambridge", "English", "Ivan", "Nikolov", 16);
            p = Collegeteacher;
            counter++;
            Console.WriteLine();
            Console.WriteLine("College Teacher Name:{0}", p.Name);
            Console.WriteLine("College Teacher Family:{0}", p.Family);
            Console.WriteLine("College Teacher Experience:{0}", p.Experience);
            Console.WriteLine("College Teacher Subject:{0}", Collegeteacher.Subject);
            Console.WriteLine("College Teacher College:{0}", Collegeteacher.College);
            p.CheckHomework();
            Console.WriteLine();
            Console.WriteLine("Number of instances of class Person is:{0}", Person.NumberOfInstances(counter));
        }
    }
}

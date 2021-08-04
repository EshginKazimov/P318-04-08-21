using System;

namespace Constructor
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Group;

        //Constructor - ozu bir methoddur, return type yoxdur, class-la eyni adda olmalidir
        //Ve yalniz object yarananda ishe dushur
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Student created 1");
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            Age = age;
            Console.WriteLine("Student created 2");
        }

        public Student(string name, string surname, int age, string group) : this(name, surname, age)
        {
            Group = group;
        }

        public string GetFullName()
        {
            return Name + " " + Surname + " " + Age;
        }

        public string GetFullNameWithGroup()
        {
            return $"{Group}: {GetFullName()}";
        }
    }
}

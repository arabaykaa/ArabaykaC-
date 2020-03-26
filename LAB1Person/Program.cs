using System;
using System.Collections.Generic;

namespace LAB1Person
{
    public class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hi");
            RandomPerson();
            Student student = new Student("Aaa");
            Type myType = student.GetType();
            Type baseType = typeof(Student);
            Console.WriteLine(myType.ToString()); //Получение типа myType, тип "Student"
            Console.WriteLine(baseType.BaseType); //Получение прародителя класса "Student"

            List<Student> kid = new List<Student>();
            kid.Add(new Student("Anton"));
            kid.Add(new Student("Anatoliy"));
            kid.Add(new Student("Antonio"));
            int size = 1;
            Teacher teacher = new Teacher("name");
            Teacher[] massive = new Teacher[size];
            massive[0] = new Teacher("TEAcher");
            massive[0].Spisok(kid);  
            //massive[1] = teacher.Spisok();
            //Console.WriteLine("Massive Teacher  " + massive.GetType());
            Console.WriteLine("Massive   " + massive[0].Display());
        }
        
        public string Name { get; set; }
        public Program(string name) { Name = name; }

        protected Program(){}

        public virtual void Print() { Console.WriteLine(Name); }

        public override string ToString() {
            return base.ToString();
        }

        public override bool Equals(object? obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        static void RandomPerson()
        {
            int[] mass = new int[10];
            int i;
            Random rand = new Random();
            for (i=0; i<mass.Length; i++)
            {
                mass[i] = rand.Next(10);
                Console.Write(" "+mass[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Mass rand number: " + mass[rand.Next(10)]);
        }
    }
}
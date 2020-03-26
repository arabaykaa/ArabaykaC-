using System;

namespace LAB1Person
{
    public class Student : Program
    {
        Student(){}
        public Student(string name) : base(name) {}

        public override string ToString() {
            return base.ToString();
        }
        public override bool Equals(object? obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        static void RandomPStudent()
        {
            int[] mass = new int[10];
            int i;
            Random rand = new Random();
            for (i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(10);
                Console.Write(" " + mass[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Mass rand number: " + mass[rand.Next(10)]);
        }

        public override void Print()
        {
            Console.WriteLine("Print name" + Name);
        }
    }
}
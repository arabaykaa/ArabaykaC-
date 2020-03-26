using System;

namespace LAB1Person
{
    public class Student : Person
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

        public override void Print()
        {
            Console.WriteLine("Print name" + Name);
        }
    }
}
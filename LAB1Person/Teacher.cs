using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace LAB1Person
{
    public class Teacher : Student
    {
        public List<Student> kid;
        List<Student> stu = new List<Student>();
        public Teacher(string name) : base(name) {}
        public void Spisok(List<Student> kids)
        {
            this.kid = kids;
        }

        public Student Display(Student a)
        {
            return a;
        }
        /*public Student Spisok(Student kids)
        {
            this.kid = kids;
            return kid;
        }*/
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
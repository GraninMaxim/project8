using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    internal class Student : ICloneable, IComparable, IHuman, IPrint
    {
        private string _name, _lastname;
        private int _age, _studentID;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public Student(string name, string lastname, int age, int studentID)
        {
            _name = name;
            _lastname = lastname;
            _age = age;
            _studentID = studentID;
        }

        public string Print()
        {
            string data = $" Имя: {Name} \n Фамилия: {Lastname} \n Возраст: {Age} \n Номер студенческого билета: {StudentID}";
            return data;
        }

        //сравнение по фамилии
        public int CompareTo(object ob)
        {
            Student student = (Student)ob;
            return this.Lastname.CompareTo(student.Lastname);
        }


        public object Clone()
        {
            return new Student(Name, Lastname, Age, StudentID);
        }
    }
}

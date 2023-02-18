using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    public class Student
    {
        private string fio;
        private int age;
        private string speciality;
        private DateTime birthday;
        private int course;
        private int group;
        private int average;
        private string se;
        private Adres adress;

        public string Fio { get { return fio; } set { fio = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Speciality { get { return speciality; } set { speciality = value; } }
        public DateTime Birthday { get { return birthday; } set { if (value.Date > new DateTime(2000, 01, 01)) birthday = value; } }
        public int Course { get { return course; } set { if (value > 5) course = value; } }
        public Adres Adress { get { return adress; } set { adress = value; } }
        public string Se { get { return se; } set { se = value; } }
        public int Group { get { return group; } set { group = value; } }
        public int Average { get { return average; } set { average = value; } }


        public Student(string fio, int age, string speciality, DateTime birthday, int course, int group, int average, string se, Adres adress)
        {
            Fio = fio;
            Age = age;
            Speciality = speciality;
            Birthday = birthday;
            Course = course;
            Group = group;
            Average = average;
            Se = se;
            Adress = adress;
        }


    }
}

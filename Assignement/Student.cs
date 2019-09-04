using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assignement.domain
{
    public class Student
    {
        private String fullname;
        private String birthday;
        private String email;
        private String address;
        private String gender;

        public Student()
        {
        }

        public Student(string fullname, string birthday, string email, string address, string gender)
        {
            this.fullname = fullname;
            this.birthday = birthday;
            this.email = email;
            this.address = address;
            this.gender = gender;
        }

        public string Fullname
        {
            get => fullname;
            set => fullname = value;
        }

        public string Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }
        
        [JsonIgnore]
        List<Student> list = new List<Student>();
        
        public Student addStudent()
        {
            Student st = new Student();
            Console.WriteLine("Please enter student Full name: \n");
            st.fullname = Console.ReadLine();
            Console.WriteLine("Please enter student Birthday: \n");
            st.birthday = Console.ReadLine();
            Console.WriteLine("Please enter student email: \n");
            st.email = Console.ReadLine();
            Console.WriteLine("Please enter student address: \n");
            st.address = Console.ReadLine();
            Console.WriteLine("Please enter student gender: \n");
            st.gender = Console.ReadLine();
            list.Add(st);
            return st;
        }

        public void getStudentInfo()
        {
            Student st = new Student();
            foreach (var student in list)
            {
                st = student;
            }
            Console.WriteLine(st.fullname + " | " + st.email + " | " + st.birthday + " | " + st.address + " | " + st.Gender);
        }
    }
}
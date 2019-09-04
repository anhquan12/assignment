using System;
using System.Collections.Generic;
using Assignement.domain;
using Newtonsoft.Json;

namespace Assignement
{
    public class ClassRoom
    {
        private String name;
        private String address;
        private List<Student> studentList;

        public ClassRoom()
        {
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public List<Student> StudentList
        {
            get => studentList;
            set => studentList = value;
        }
        
        [JsonIgnore]
        List<ClassRoom> list = new List<ClassRoom>();
        
        public void addClassRoom()
        {
            ClassRoom classRoom = new ClassRoom();
            Console.WriteLine("Please enter Class name: \n");
            classRoom.Name = Console.ReadLine();
            Console.WriteLine("Please enter Class address: \n");
            classRoom.address = Console.ReadLine();
            Console.WriteLine("Please enter student: \n");
            Student st = new Student().addStudent();
            studentList.Add(st);
        }

        public void getStudentInfo()
        {
            ClassRoom cr = new ClassRoom();
            foreach (var classRoom in list)
            {
                cr = classRoom;
            }
            Console.WriteLine(cr.Name + " | " + cr.address + " | ");
        }
    }
}
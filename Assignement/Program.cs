using System;
using System.Collections.Generic;
using System.IO;
using Assignement.domain;
using Newtonsoft.Json;

namespace Assignement
{
    class Program
    {
        static List<ClassRoom> classList = new List<ClassRoom>();
        static void Main(string[] args)
        {
            Int32 value;
            while (true)
            {
                Console.WriteLine("Please Choice");
                Console.WriteLine("1. Input data from json.");
                Console.WriteLine("2. Read data in List");
                Console.WriteLine("3. Save to file obj");
                Console.WriteLine("Please enter number: \n");
                value = Convert.ToInt32(Console.ReadLine());
                menu(value);
            }
        }

        static void menu(int value)
        {
            switch (value)
            {
                case 1:
                    loadJson();
                    break;
                case 2:
                    readClassRoom();
                    break;
                case 3:
                    break;
            }
        }

        static void loadJson()
        {
            using (StreamReader r = new StreamReader("/Users/anhquan12/Desktop/data.json"))
            {
                string json = r.ReadToEnd();
                classList = JsonConvert.DeserializeObject<List<ClassRoom>>(json);
            }
        }

        static void readClassRoom()
        {
            for (int i = 0; i < classList.Count; i++)
            {s
                Console.WriteLine(classList[i].Address);
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collection_HashTable_Oct_070125
{
    class Student
    {
        public int roll { get; set; }
        public string  name { get; set; }
        public String Address { get; set; }
        public void showStudent()
        {
            Console.WriteLine($"Roll:{roll} Name:{name} Address:{Address}");
        }
    }
    internal class Student_HashTable
    {
        Hashtable HTCollege = new Hashtable();//key & value-->student obje retrive

        public string SearchStud(int roll,out Student s)
        {
            s = null;
            var keys = HTCollege.Keys;
            foreach (var k in keys)
            {
                ArrayList stArlist = (ArrayList) HTCollege[k];

                foreach (Student std in stArlist)
                {
                    if (std.roll==roll)
                    {
                        s = std;
                        return k.ToString();
                    }
                }
            }            
            return null;
        }
        public void showHT()
        {
            var keys= HTCollege.Keys;
            foreach (var k in keys)
            {
                Console.WriteLine("Dept:"+k);
                var studs = (ArrayList)HTCollege[k];
                foreach (Student std in studs)
                {
                    std.showStudent();
                }
            }
        }
        public void Add_Students()
        {
            
            Student s2 = new Student() { roll = 2, name = "Mahesh", Address = "Nashik" };//2000
            //FE
            ArrayList FEArList=new ArrayList() 
            {
                new Student(){ roll=1,name="rajesh",Address="pune"},
               s2
            };
            HTCollege.Add("FE", FEArList);
            //SE
            ArrayList SEArList = new ArrayList()
            {
                new Student(){ roll=3,name="vinod",Address="nagar"},
                new Student(){ roll=4,name="Darshan",Address="mumbai"},
            };
            HTCollege.Add("SE", SEArList);

        }
    }
}

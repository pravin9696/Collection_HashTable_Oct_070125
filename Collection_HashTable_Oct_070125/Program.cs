using System;
using System.Collections;
namespace Collection_HashTable_Oct_070125
{
    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
    }


    class PersonOperations
    {
        public ArrayList MyArList  { get; set; }
        public void AddIntoArrayList()
        {
            MyArList = new ArrayList();
            string nm;
            int ag;
            char ch;
            do
            {
                Console.WriteLine("enter Name and age of Person");
                nm = Console.ReadLine();
                ag=int.Parse(Console.ReadLine());
                Person p=new Person() { Name = nm, Age = ag };
                MyArList.Add(p);


                Console.WriteLine("do you want to continue? Y/N");
                //char ch = (char)Console.Read();
                 ch = Console.ReadLine()[0];
            }while (ch=='Y'|| ch=='y');
        }
        public void showArrayList()
        {
            Console.WriteLine("Array list elements are:");

            //foreach (var item in MyArList)
            //{
            //    Person p = (Person)item;
            //    Console.WriteLine("Name :" + p.Name + "  Age:" + p.Age);
            //    MyArList.Remove(item);
            //}
            for (int i = 0; i < MyArList.Count; i++)
            {
                /*var x = MyArList[i];
                Person pp=(Person)x;
                Console.WriteLine(pp.Name+" "+pp.Age);
                */
                Console.WriteLine(((Person)MyArList[i]).Name+"***"+ ((Person)MyArList[i]).Age);
            }
        }
    }


    class ArrayListWithCustomeObjects
    {
        public void ArrayListDemo()
        {
            ArrayList Arlist = new ArrayList();
            //-------------------------
            Person p1 = new Person();
            p1.Name = "rajesh";
            p1.Age = 23;
            Arlist.Add(p1);
            //--------------------------------
            Person p2 = new Person() { Name = "vinod", Age = 26 };
            Arlist.Add(p2);
            //--------------------------------------------
            Arlist.Add(new Person() { Name = "ashish", Age = 21 });
            Arlist.Add(new Person() { Name = "dinesh", Age = 23 });
            Arlist.Add(new Person() { Name = "Pankaj", Age = 27 });




            foreach (Person p in Arlist)
            {
                Console.WriteLine(p.Name + " " + p.Age);
            }
            Console.WriteLine("===================================");
            foreach (var v in Arlist)
            {
                //Person v1 = v as Person;
                Person v2 = (Person)v;
                Console.WriteLine(v2.Name+" "+v2.Age);
            }

        }
    }

    public class HashTableDemo
    {
        Hashtable states = new Hashtable();

        public string SearchCity(string cty)
        {
            var keys = states.Keys;

            foreach (var st in keys)
            {
                var cities = (ArrayList)states[st];
                if (cities.Contains(cty))
                {
                    return st.ToString();
                }
            }
            return null;
        }
        public void display_HT()
        {
            var keys = states.Keys;
            foreach (var st in keys)
            {
                var cities = states[st];
                ArrayList citiArlist = (ArrayList)cities;
                Console.WriteLine("state:" + st);
                foreach (var ct in citiArlist)
                {
                    Console.Write(" " + ct);
                }
                Console.WriteLine();
            }
        }
        public void state_cities()
        {
           
            ArrayList mcities = new ArrayList() {
               "pune","mumbai","nashik","nagar"
            };
            states.Add("maharashtra", mcities);

            ArrayList Kcities = new ArrayList()
            {
                "banglore","manglore","Mysoor"
            };
            states.Add("karnataka", Kcities);



            //------------------------------

           
        }
        public void HTTry()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("Maharashtra", "Mumbai");
            ht1.Add("Bihar", "Patana");
            ht1.Add("Karnataka", "Banglore");
            ht1.Add("Goa", "Panji");


            Console.WriteLine("all keys in HT");
            var keys1=ht1.Keys;

            foreach (var item in keys1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("all values in HT");
            var v = ht1.Values;

            foreach (var item in v)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------");
            var v2 = ht1["Goa"];
            Console.WriteLine(v2);

            bool check=ht1.Contains("Goa");
            bool val3 = ht1.ContainsValue("Mumbai");
            Console.WriteLine("Goa key ? "+check);

            Console.WriteLine("value Mumbai ?"+val3);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // //ArrayListWithCustomeObjects ob = new ArrayListWithCustomeObjects();
            // //ob.ArrayListDemo();


            // PersonOperations PO = new PersonOperations();
            // PO.AddIntoArrayList();
            // PO.showArrayList();
            //// PO.AddIntoArrayList();
            ///

            // HashTableDemo htd = new HashTableDemo();
            // //htd.HTTry();
            // htd.state_cities();
            // htd.display_HT();


            // string ct;
            // Console.WriteLine("Enter City name to find State");
            // ct = Console.ReadLine();
            //string StName= htd.SearchCity(ct);

            // if (string.IsNullOrEmpty(StName))
            // {
            //     Console.WriteLine("State not found!!!");
            // }
            // else
            // {
            //     Console.WriteLine($"{ct} belogns to {StName}");
            // }

            Student_HashTable sht = new Student_HashTable();
            sht.Add_Students();
            sht.showHT();
            Student tempStud;
            var result = sht.SearchStud(14,out tempStud);
            //result ==> null or "FE/SE/TE/BE"
            Console.WriteLine("-----Student Search Result -------");
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Student Not found!!!");
            }
            else
            {
                Console.WriteLine("Dept:"+result);
                tempStud.showStudent();
            }
            Console.ReadKey();
        }
    }
}

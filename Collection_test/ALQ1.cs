using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_test
{
    class ALQ1
    {
       
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            ArrayList al2 = new ArrayList();
            foreach(string s in al)
            {
                if (al2.Contains(s) == false)
                {
                    al2.Add(s);
                }
            }
            foreach (string e in al2)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
    class Question2
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Radhika");
            al.Add("Krishna");
            al.Add("Hari");
            al.Add("Govind");
            al.Add("Lalita");
            Console.WriteLine("sorted arraylist");
            al.Sort();
            foreach (string e in al)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("sorted reverse arraylist");
            al.Reverse();
            foreach (string e in al)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
    class Question3
    {

        static int Potantial(string s)
        {
            return 0;
        }
        static void Main()
        {
            int sum = 0,a;
            string ss = Console.ReadLine();
            string s = ss.ToUpper();
            string[] sp=s.Split(' ');
            
            //int len = sp.Length;
            //Console.WriteLine(sp[len]);
           // dynamic add = new int[len];
            for (int i = 0; i < sp.Length; i++)
            {
             
                char[] ch = sp[i].ToCharArray();
                for (int j = 0; j <ch.Length; j++)
                {
                    if (ch[j] >= 'A' && ch[j] < 'Z') 
                    {
                        a = ch[j] - 64;
                       
                        sum = sum + a;
                    }
                }
                Console.WriteLine(sp[i] + "=" + sum);
                
            }
            Console.ReadLine();

        }
    }
    class player
    {

    }
    class QUESTION_5
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "One");
            ht.Add("2", "Two");
            ht.Add("3","three");
            ht.Add("4", "Four");
            object key = Console.ReadLine();
            object val = Console.ReadLine();
            ht[key] = val;
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);

            }
            Console.ReadLine();
        }
    }
    class Question6
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "One");
            ht.Add("2", "Two");
            ht.Add("3", "Three");
            ht.Add("4", "Four");
            ht.Add("5", "Five");
            ht.Add("6", "Six");
            ht.Add("7", "Seven");
            ht.Add("8", "Eight");
            ht.Add("9", "Nine");
            ht.Add("10", "Ten");
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);

            }

            Console.ReadLine();
        }
    }
    class Question7
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"One");
            ht.Add(2,"Two");
            ht.Add(3,"Three");
            ht.Add(4,"Four");
            ht.Add(5,"Five");
            ht.Add(6,"Six");
            ht.Add(7,"Seven");
            ht.Add(8,"Eight");
            ht.Add(9,"Nine");
            ht.Add(10,"Ten");
           
            foreach (object d in ht.Keys)
            {
                int data = (int)d;
                if (data % 3 == 0)
                    Console.WriteLine(d + ":" + ht[d]);

            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);

            }
            Console.ReadLine();
        }
    }
    class Question8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            Hashtable ht = new Hashtable();
            foreach (dynamic str in al)
            {
                if (ht.ContainsKey(str))
                {
                    int oldval = ht[str];
                    ht[str] = oldval + 1;
                }
                else
                    ht.Add(str, 1);
            }
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key + ":" + e.Value);
            }
            Console.ReadLine();
        }
    }
    class Enceyption
    {
        static int Potential(string ss)
        {
            
            
            int sum = 0,a;
                           
                for (int j = 0; j < ss.Length; j++)
                {
                    if (ss[j] >= 'A' && ss[j] < 'Z')
                    {
                        a = ss[j] - 64;

                        sum = sum + a;
                    }
                }
               
            return sum;
        }
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
                ss = ss.ToUpper();

            //ss="my name is riya
            string[] arr = ss.Split();
           for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if(Potential(arr[j])> Potential(arr[j+1]))
                    {
                        // swap
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }

           foreach(string wrd in arr)
                Console.Write(wrd+" ");
            Console.ReadLine();
        }
    }
    class Abcd
    {
        int playerid;
        string playername,country,team;

        public Abcd(int playerid, string playername, string country, string team)
        {
            this.Playerid = playerid;
            this.Playername = playername;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Playername { get => playername; set => playername = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        static void Main(string[] args)
        {
            Abcd p1 = new Abcd(1,"Doni","India","csk");
            Abcd p2 = new Abcd(2, "Raina", "India", "csk");
            Abcd p3 = new Abcd(3, "Koholi", "India", "csk");
            Abcd p4 = new Abcd(4, "Andru", "India", "csk");
            Abcd p5 = new Abcd(5, "Bravo", "Astrolia", "mi");
        }

        public override bool Equals(object obj)
        {
            var abcd = obj as Abcd;
            return abcd != null &&
                   playerid == abcd.playerid &&
                   playername == abcd.playername &&
                   country == abcd.country &&
                   team == abcd.team;
        }

        public override int GetHashCode()
        {
            var hashCode = -1523557875;
            hashCode = hashCode * -1521134295 + playerid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(playername);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(team);
            return hashCode;
        }
    }
    class Fibo
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,c;
            for (int i = 1; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
               
            }
            Console.ReadLine();
        }
    }
    class Programming_Language
    {
        
       
        static void Main(string[] args)
        {
           
            List<Language> s = new List<Language>();
            s.Add(new Language("C Language"));
            s.Add(new Language("C++"));
            s.Add(new Language("C#"));
            s.Add(new Language("Java"));
            s.Add(new Language("Python"));
            foreach (object q in s)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            s.Sort();
            foreach (object q in s)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }
    class Language:IComparable<Language>
    {
        string lan_name;
        Language()
        { }
       
        public Language(string lan_name)
        {
            this.lan_name = lan_name;
        }
        public string lan_nameproperty
        { get { return lan_name; } set { lan_name = value; } }

        public int CompareTo(Language other)
        {
            
                return this.lan_name.CompareTo(other.lan_name);
        }

        public override string ToString()
        {
            return $"Language=>{lan_name}";
        }
    }
    class Debug_start
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee("S.P.Krishnamurty", "CMO", 40000));
            emp.Add(new Employee("K.P.Narayan", "CTO", 70000));
            emp.Add(new Employee("B.U.Bhat", "COO", 80000));
            emp.Add(new Employee("K.V.Yadav", "CEO", 90000));
            emp.Add(new Employee("A.M.Chaturvedy", "CFO", 50000));
            foreach (object q in emp)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("///////////////////////////////////////////////////////");
            emp.Sort(new sortbysalary());
            foreach (object q in emp)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }

    }
    class sortbysalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            dynamic val = (x.Salary > y.Salary) ? -1 : (x.Salary < y.Salary) ? 1 : 0;
            return val ;
        }
    }
    class Employee:IComparable<Employee>
    {
        string name, designation;
        long salary;
        public Employee()
        { }

        public Employee(string name, string designation, long salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public long Salary { get => salary; set => salary = value; }

        public int CompareTo(Employee other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return $"Name={name} designation={designation} Salary={salary}";
        }
    }
    class Question_3
    {
        static void Main(string[] args)
        {
            Queue<string> colors = new Queue<string>();
            colors.Enqueue("Green");
            colors.Enqueue("Blue");
            colors.Enqueue("Red");
            colors.Enqueue("Yellow");
            colors.Enqueue("orange");
            foreach (object q in colors)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }

    }
    class Ques_4
    {
        static void Main(string[] args)
        {
            HashSet<School> sh = new HashSet<School>();
            sh.Add(new School(1, "Ram vidyalaya", 98));
            sh.Add(new School(2, "shaam vidyalaya", 97));
            sh.Add(new School(1, "Ram vidyalaya", 98));
            foreach (object q in sh)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        
        }
    }
   public class School:IEquatable<School>
    {
        int stud_id;
        string name;
        int percent;

        public School(int stud_id, string name, int percent)
        {
            this.Stud_id = stud_id;
            this.Name = name;
            this.Percent = percent;
        }

        public int Stud_id { get => stud_id; set => stud_id = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }

        public override bool Equals(object obj)
        {
            return Equals(obj as School);
        }
        public bool Equals(School other)
        {
            return other != null &&
                Stud_id == other.Stud_id &&
                Name == other.Name &&
                Percent == other.Percent;
        }

        public override int GetHashCode()
        {
            return 0;//HashCode.Combine(Stud_id, Name, Percent);
        }

        public override string ToString()
        {
            return $"Students ID={stud_id} Name={name} Percent={percent}";
        }
    }
    // 5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
   
}

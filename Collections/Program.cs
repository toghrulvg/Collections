namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<int> nums = new List<int>();

            //nums.Add(13);
            //nums.Add(34);
            //nums.Add(8);
            //nums.Add(1);

            //    {
            //        Console.WriteLine(nums[2]);
            //    }



            //    foreach (var item in nums)
            //    {
            //        Console.WriteLine(item);
            //    }


            //    for (int i = 0; i < nums.Count; i++)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }


            //    if (nums.Count == 4)
            //    {
            //        Console.WriteLine("List Count is {0}", nums.Count);
            //    }


            //}


            //    List<string> words = new List<string>();

            //    words.Add("Toghrul");
            //    words.Add("Ali");
            //    words.Add("Fidan");
            //    words.Add("Seadet");

            //    Console.WriteLine(words[2]);

            //    foreach (var item in words)
            //    {
            //        Console.WriteLine(item);
            //    }


            //    for (int i = 0; i < words.Count; i++)
            //    {
            //        Console.WriteLine(words[i]);
            //    }


            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Toghrul";
            //people.Add(person1);

            //Person person1 = new Person();
            //person1.Name = "Toghrul";
            //person1.Id = 4;
            //person1.Email = "toghrulvg@code.edu.az";

            //people.Add(person1);

            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Seadet",
            //    Email = "Seadet18@gmail.com"
            //};



            //people.Add(new Person { Id = 1, Name = "Toghrul", Email = "toghrulvg@gmail.com" });
            //people.Add(new Person { Id = 11, Name = "Vasif", Email = "Abasov@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Jamal", Email = "Alieff@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Soltan", Email = "Shahmuradli@gmail.com" });

            //GetStudents(people);

            //GetNumbers(nums);

            //Console.WriteLine(person2.Name);

            //var result = GetPersonByName(people, "Toghrul");
            //Console.WriteLine(result.Name + "-" + result.Id + "-" + result.Email);


            //    var result = GetPeopleByName(people, "Toghrul");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.Name + "-" + item.Id + "-" + item.Email);
            //    }

            //}



            //public static List<Person> GetPeopleByName(List<Person> people, string name)
            //{
            //    var person = people.FindAll(m => m.Name == name);
            //    return person;
            //}



            //public static Person GetPersonByName(List<Person> people, string name)
            //{
            //    var person = people.Find(m => m.Name == name);
            //    return person;

            //}
            //}






            //Hashtable datas = new Hashtable();

            //datas.Add(1, "Toghrul");
            //datas.Add(2, "Vasif");

            ////foreach (var item in datas.Keys)
            ////foreach (var item in datas.Values)
            //foreach (DictionaryEntry item in datas)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}




            //SortedList datas = new SortedList();
            //datas.Add(1, "Togrul");
            //datas.Add(5, "Vasif");
            //datas.Add(7, "Soltan");
            //datas.Add(2, "Jamal");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}


            //SortedList<int, string> datas = new SortedList<int, string>();
            //datas.Add(6, "Toghrul");
            //datas.Add(7, "Soltan");

            //foreach (KeyValuePair<int, string> item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}



            //ArrayList datas = new ArrayList();

            //datas.Add("High");
            //datas.Add(1);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}




            //HashSet<int> datas = new HashSet<int>();

            //datas.Add(1);
            //datas.Add(2);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}



            //Stack<int> datas = new Stack<int>();

            //datas.Push(11);
            //datas.Push(24);
            //datas.Push(13);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> datas = new Queue<int>();

            //datas.Enqueue(11);
            //datas.Enqueue(24);
            //datas.Enqueue(13);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}



            //        Dictionary<string, string> datas = new Dictionary<string, string>();

            //        datas.Add("Admin", "Togrul");
            //        datas.Add("Member", "Soltan");
            //        datas.Add("Superadmin", "Cavid");

            //        foreach (KeyValuePair<string,string> item in datas)
            //        {
            //            //Console.WriteLine($"Name : {item.Value}, Role : {item.Key}" );


            //            if(item.Key == "Admin")
            //            {
            //                Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");
            //                break;
            //            }
            //        }


            //    }



            //    public static void GetStudents(List<Person> students)
            //    {
            //        foreach (var stud in students)
            //        {
            //            Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2}", stud.Id, stud.Name, stud.Email);
            //        }
            //    }




            //    public static void GetNumbers(List<int> numbers)
            //    {
            //        foreach (var item in numbers)
            //        {
            //            Console.WriteLine(item);
            //        }
        }
    }
}
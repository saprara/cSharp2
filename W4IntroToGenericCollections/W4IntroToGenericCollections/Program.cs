using System.Collections;

namespace W4IntroToGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] array = new int[4];
             array[0] = 10;
             array[1] = 20;
             array[2] = 30;
             array[3] = 40;

                 int sum = 0;
             for(int i=0;i<array.Length; i++)
             {
                  int num = array[i];
                 sum += num;

             }
             //Console.WriteLine("sum = " + sum);
             //arraylist

             ArrayList arrayList = new ArrayList();
             arrayList.Add(10);
             arrayList.Add(20);
             arrayList.Add(30);
             arrayList.Add(40);
             sum = 0;
             for(int i=0; i<arrayList.Count ; i++)
             {
                 int num =(int) arrayList[i];
                 sum += num;

             }
             Console.WriteLine("\n\n\nsum = " + sum);


             //List
             List  <int> list = new List<int>();

             list.Add(10);

             list.Add(20);
             Console.WriteLine(list.Capacity);
             list.Add(30);
             list.Add(40);
             list.Add(50);
             list.Add(50);
             list.Add(50);
             list.Add(50);
             list.Add(50);
             Console.WriteLine(list.Count);
             Console.WriteLine(list.Capacity);
             sum = 0;
             for (int i = 0; i < list.Count; i++)
             {
                 int num = list[i];
                 sum += num;

             }
             Console.WriteLine("\n\n\nsum = " + sum);*/
            Employee em1 = new Employee(01, "John", 50000);
            Employee em2 = new Employee(02, "jack", 60000);
            Employee em3 = new Employee(03, "jamie", 70000);
            List<Employee> Employees = new List<Employee>();


            Employees.Add(em1);
            Employees.Add(em2);
            Employees.Add(em3);
            // Employees.Insert(2,em2);
            //Employees.Clear();



            foreach (Employee e in Employees)
            {
                Console.WriteLine(e);
            }
            //searching
            //indexOf
            int index = Employees.IndexOf(em1);
            Console.WriteLine(Employees.Contains(em3));
            Console.WriteLine(Employees.Exists(s => s.Name.StartsWith('J')));
            Console.WriteLine(Employees.Find(s => s.Name.StartsWith('J')));

            Console.WriteLine("\n\n\n Dcitionary example");
            Dictionary<int, Employee> dictEmps = new Dictionary<int, Employee>();
            dictEmps.Add(em1.Id, em1);
            dictEmps.Add(em2.Id, em2);
            dictEmps.Add(em3.Id, em3);
           /* Console.WriteLine("enter key");
            int key = int.Parse(Console.ReadLine());
            if (dictEmps.ContainsKey(key)) {
                Console.WriteLine("loading......\n\n\n\n\n");
                Employee emp10 = dictEmps[key];
            Console.WriteLine(emp10);
        }
        else
        Console.WriteLine("key not found");
            foreach(KeyValuePair<int, Employee> kvp in dictEmps)
            {
                Console.WriteLine(kvp.Value);
            }
           */
            //stack
            Console.WriteLine("\n\n\n\n\n\n stack starting");
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            foreach(int i in stack)
            {
                Console.WriteLine("\n"+i);
            }

            //queue
            Console.WriteLine("\n\n\n\n Queue starting");
               Queue<int> q = new Queue<int>(4);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
           // Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Max());
            Console.WriteLine("tHIS ONE"+q.Count);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("tHIS ONE" + q.Count);

            foreach (int i in q)
            {
                Console.WriteLine("\n"+i);
            }


        }
        
    }
}

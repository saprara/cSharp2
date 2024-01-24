namespace IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 20;
             String b = "unchanged";
             int[] c = { 1, 2, 3, 4, 5, 6 };
             String[] v = { "unchanged", "unchanged" };

             Console.WriteLine("\n\nnum is " + a);
             Console.WriteLine("The String is " + b);
             Console.WriteLine("the array starts with " + c[0]);
             Console.WriteLine("the array starts with " + v[0]);

             ChangeValue(ref a, ref b, ref c, ref v);

             Console.WriteLine("\n\nnow num is " + a);//not changed
             Console.WriteLine("Now the string is " + b);//not changed
             Console.WriteLine("now the array start with " + c[0]);//changed
             Console.WriteLine("now the array start with " + v[0]);//changed


             int x = 10, y = 20;
             int sum, mul;
             Calculate(x, y, out sum, out mul);
             Console.WriteLine("\n\nthe sum of x&y is " + sum);
             Console.WriteLine("the product of x&y is " + mul);

             Console.Write("\n\nENTER A NUMBER");
             if (int.TryParse(Console.ReadLine(), out int n)) {
                 Console.WriteLine("you enter " + n);
             }
             else { 
                     Console.WriteLine("invalid input !try again ");
            */
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(arr);
            PrintArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 65, 4, 3, 2, 2, 4, 44, 3, 2, 2, 3, 3, 2, 2, 3, 3, 3333, 2);
            String s = "hello";
            Console.WriteLine(s.Trim('o','l','h'));
            PersonInfo(age: 45, name:"jack");
            PersonInfo("jon");

        }
            static void PrintArray(params int[] arr)
            {
                Console.WriteLine("\n\n number of items: "+ arr.Length);
                foreach (int i in arr) 
                    Console.Write(i + " ");
                Console.WriteLine();
            }
        static void PersonInfo(string name, int age=90)
        {

        }



        
        static void Calculate(int x, int y,out int sum,out int mul)
        {
            sum = x + y;
            mul = x * y;
            
        }
        static void ChangeValue(ref int n,ref String s, ref int[] arr, ref String[] i) 
        {
            arr[0] = 100;
            i[0] = "changed";
            n = 100;
            s = "changed ";

        }
    }
}

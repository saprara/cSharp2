namespace W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 65;

            Console.WriteLine((char)num1);
            int num = 5;
            object obj = num; //boxing
           obj = "hello";
            //Console.WriteLine(obj);
            if(obj is int)
            {
                num = (int)obj;//unboxing

            }
            Console.WriteLine(AreEqual("hello","Hello"));
            Console.WriteLine(AreEqual(65,'A'));
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            printArray(intArray);
            printArray(doubleArray);
            printArray(charArray);




        }
        //non generic methods have performance issue, and they are not type safe
        static bool AreEqual(object var, object var2)
        {
            return (var.Equals(var2));
        }

        //generic methods
        static bool AreEqual<T>(T value1,  T value2)
        {
            return value1.Equals(value2);

        }
        static void printArray<T>(T[] array)
        {
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }
}

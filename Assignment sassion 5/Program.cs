namespace Assignment_sassion_5
{
    internal class Program
    {

        public static void PassingByValue(int x)
        {
            int X = 100;
        }
        public static void PassingByRefence(ref int x)
        {
            int X = 100;
        }

        static void Main(string[] args)
        {

            #region Q1  
            int A = 10;
            int B = 20;
            PassingByValue(A);
            Console.WriteLine($"Value of a after PassByValue: {A}");
            PassingByRefence( ref B);
            Console.WriteLine($"Value of a after PassByValue: {B}");
            #endregion
        }
    } 



}

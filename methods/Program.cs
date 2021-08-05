using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int A = 10;
            int B = 10;
            int C = 10;
            int D = 10;
            int[] array1 = { A, B, C, D };
            Console.WriteLine("What is your name?");
            String nameString = Console.ReadLine();
            Console.WriteLine("What is the name of your pet?");
            String petString = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            String colorString = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            String bandString = Console.ReadLine();
            Console.WriteLine($"{nameString} is your name, {petString} is your pet, {colorString} is your favorite color, and {bandString} is your favorite band.");
            Console.WriteLine($"{Add(A, B)}");
            Console.WriteLine($"{Program.Subtract(C, D)}");
            var sum = Program.Addup(array1);
            Console.WriteLine(sum);
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6));
            
        }
        public static double Add (double A , double B)
        {
            return A + B;
        }
        public static double Subtract(double A, double B)
        {
            return A - B;
        }
        public static double Multiply(double A, double B)
        {
            return A * B;
        }
        public static double Quotient(double A, double B)
        {
            return A / B;

        }
        public static double Modulus(double A, double B)
        {
            return A % B; 
        }
        public static int Addup(params int[] values)
        {
            int sum = 0;
            foreach (int i in values)
            {
                sum += i;

            }
            return sum;
        }
        public static int Add(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        
        }
    
    
    }
}

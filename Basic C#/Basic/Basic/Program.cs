namespace Basic
{
    internal class Program
    {
        // method
        public static void add(int a, int b)
        {
            int c = a + b;
            System.Console.WriteLine(c);
        }
        public static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"hello {a}");

            // TYPE CASTING:
            // Implicit casting (Automatic): char -> int -> long -> float -> double ->
            // Explicit casting (Manual): double -> float -> long -> int -> char ->

            // Explicit casting
            double salary = 1000.50;
            int salaryChar = (int)salary;
            Console.WriteLine(salaryChar);

            // Type casting with Convert class
            int salaryInt = 1000;
            double salaryDouble = Convert.ToDouble(salaryInt);
            Console.WriteLine(salaryDouble);

            // Type casting with Parse method
            string salaryString = "1000";
            int salaryInt2 = int.Parse(salaryString);
            Console.WriteLine(salaryInt2);

            // Implicit casting
            int salaryInt3 = 1000;
            double salaryDouble2 = salaryInt3;
            Console.WriteLine(salaryDouble2);



            // USER INPUT:
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age}");

            // MATH OPERATIONS:
            double num1 = 10;
            double num2 = 322;
            double div = (num1 / num2);
            Console.WriteLine(div); // 0.031055900621118012
            Console.WriteLine(Math.Round(div, 2)); // 0.03
            Console.WriteLine(div.ToString("F2")); // 0.03


            // SWITCH CASE:
            int i = 3;
            string s;

            switch (i)
            {
                case 1:
                    s = "One";
                    break;

                case 2:
                    s = "Two";
                    break;

                case 3:
                    s = "Three";
                    break;

                default:
                    s = "Default";
                    break;
            }
            Console.WriteLine(s); // Three

            // SHORTHAND SWITCH CASE:
            int i2 = 3;
            string s2 = i2 switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Default",
            };
            Console.WriteLine(s2); // Three


            // METHOD CALL:
            add(10, 20);

        }
    }
}

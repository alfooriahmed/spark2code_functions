namespace Absolute_Difference
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter The First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter The Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num2 - num1;
            int absolot_value = Math.Abs(result);
            Console.WriteLine( "your positive result: " + absolot_value);

        }
    }
}

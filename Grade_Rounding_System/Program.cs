namespace Grade_Rounding_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Exam Score: ");
            float num = float.Parse(Console.ReadLine());

           // Console.WriteLine(
               double number =  Math.Round(num);

            Console.WriteLine(number);

            if (number >= 60)
            {
                Console.WriteLine("Your score is " + number + "! You passed! your ");

            }
            else
            {
                Console.WriteLine("Your score is "+ number + "! You Failed!");
            }

            
        }
    }
}

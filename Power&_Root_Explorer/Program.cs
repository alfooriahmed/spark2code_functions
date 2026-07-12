namespace Power__Root_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.Write("Enter a Number: ");
            double num = int.Parse(Console.ReadLine());

            double result = Math.Pow(num, 2);
            Console.WriteLine(result);

            double result2 = Math.Sqrt(num);
            Console.WriteLine(result2);

            //Console.WriteLine(Math.Sqrt(num));
            



            Console.WriteLine("Your Number Is: " + num+ " And The Square Is: " +  result + " And The Square Root Is: " + result2);
        }
    }
}

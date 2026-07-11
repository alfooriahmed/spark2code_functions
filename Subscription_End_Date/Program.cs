namespace Subscription_End_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number of free trail days: ");
            int freeTrailDays = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime EndDateOFFreeTRail = today.AddDays(freeTrailDays);

            // to print the end date in format: ToString("yyyy-MM-dd")
            string endDate = EndDateOFFreeTRail.ToString();
            Console.WriteLine("The end date of your subscription is: " + endDate);
            //Console.WriteLine("The end date of your subscription is: " + EndDateOFFreeTRail);
        }
    }
}

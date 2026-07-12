namespace Membership_Expiry_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter The Membership Starting Date: ");
            string starting_date = Console.ReadLine();

            DateTime convertedDate = DateTime.Parse(starting_date);




            Console.Write("Enter The Vaild Membership Days: ");
            int valid_days = int.Parse(Console.ReadLine());

            //Console.WriteLine(valid_days );
            //Console.WriteLine(convertedDate);

            // we will now add the valid days with the end date, to check if the result will be > than tha actul date or not
            DateTime enddate = convertedDate.AddDays(valid_days);
            Console.WriteLine( "The end date of your subscribtion is: " + enddate);

            DateTime today = DateTime.Today;
            Console.WriteLine("Today date is: " + today);

            if (today <= enddate)
            {
                Console.WriteLine("Active");
            }

            else
            {
                Console.WriteLine("Expired");
            }



        }
    }
}

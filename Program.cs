namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double busPass, busPass2;
            busPass = 2.00;
            busPass2 = 3.50;
            int age;+
            Console.WriteLine("Hello there, how old are you?");
            double.TryParse(Console.ReadLine(), out busPass);

            if (age >= 12 && age <= 60)
            {
                Console.WriteLine("Your buss pass will be " + busPass);
            }
            else 
            {
                Console.WriteLine("You bus pass will cost you" + busPass2);
            }



        }
    }
}

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args, double earthWeight)
        {
            //Topic 5 assingment question 1

           
            
            double earthWeight;
            double spaceWeight;
            string planet;
            Console.WriteLine("Please enter your current earth weight.");
            earthWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I have information for the following planets");
            Console.WriteLine("1. Venus  2. Mars  3. Jupiter  4. Saturn  5. Uranus  6. Neptune");
            Console.WriteLine(" Which planet are you visiting");
            planet = Console.ReadLine().ToLower();


            if (planet == "1" || planet == "venus")
            {
                spaceWeight = earthWeight * 0.7;
                Console.WriteLine("Your weight on venus is" + spaceWeight);
            }





        }
    }
}

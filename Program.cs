namespace Exercises_Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int tal = int.Parse(Console.ReadLine());
            if (tal >= 0)
            {
                Console.WriteLine("you'v enterd a positiv number");
            }
            else
            {
                Console.WriteLine("you'v enterd a negativ number");
            }
        }
    }
}

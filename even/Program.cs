namespace project_maram
{

    internal class Program
    {
        static void Main(string[] args)
    {
       
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        int evencount = 0;


            CountEvens.CountEvens(numbers, ref evencount);

        // evenCount now contains the number of even integers in the array
        Console.WriteLine($"There are {evencount} even numbers in the array.");

        Console.ReadLine(); // To keep the console window open
    }
}
}
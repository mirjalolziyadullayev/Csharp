internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine shows something that you gave as value on terminal
        //Console.Readline takes input from user and stores value to variable

        int son1;
        Console.WriteLine("enter number:");
        //Console.ReadLine takes input from user as string
        son1 = int.Parse(Console.ReadLine());
        Console.WriteLine(son1);
        // pasing string to integer variable using int.Parse() and Console.ReadLine

        int char1;
        Console.WriteLine("enter character:");
        //Console.Read takes input from user as string and gives ASCII value
        char1 = Console.Read();
        Console.WriteLine(char1);

        ConsoleKeyInfo key;
        Console.WriteLine("enter any key:");
        //Console.ReadKey takes input from user as type ConsoleKeyInfo and gives value of key
        key = Console.ReadKey();
        Console.WriteLine(key);
    }
}

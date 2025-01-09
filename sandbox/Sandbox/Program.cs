using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {1, 9, 6, 7, 5, 9};
 
        // Sort array in ascending order.
        Array.Sort(arr);
        Console.WriteLine("Ascending: ");
          foreach(int value in arr)
        {
            Console.Write(value + " ");
        }
       
        // reverse array
        Array.Reverse(arr);
        Console.WriteLine("\n\nDescending: ");
        // print all element of array
        foreach(int value in arr)
        {
            Console.WriteLine(value + " ");
        }

        List<int> numbers = new List<int>();
        //Above created a list for user input
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string v = Console.ReadLine();
        int number = int.Parse(v);
        // Above coverted the input to an int

        while (number !=0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            v = Console.ReadLine();
            number = int.Parse(v);
        }
        int[] a = numbers.ToArray();
         Array.Sort(a);
        Console.WriteLine("Ascending: ");
          foreach(int value in a)
        {
            Console.Write(value + " ");
        }
    }
}


        
    
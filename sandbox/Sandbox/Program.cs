using System;

class Program
{
    static void Main(string[] args)
    {
            int[] letters = {3,6,8,10,0};

    Array.Sort(letters);

    foreach (int letter in letters)
    {
      Console.Write(letter + " ");
    }
    }
}
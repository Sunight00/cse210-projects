using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your Grade:");
        string g = Console.ReadLine();
        // converting g (grade) to integer
        int grade = int.Parse(g);

        if (grade>=90)
        {
            /* this is to determine the last digit in grade using the modulo divided by 10. 
            Then i can assign the + or - to the grade output*/
            int x = grade % 10;
            if (x>=7)
            {
                Console.WriteLine("A");
            }
            else if (x<3)
            {
                string sign = "-";
                Console.WriteLine($"A{sign}");
            }
            
        }
        else if (grade>=80)
        {
            int x = grade % 10;
            if (x>=7)
            {
                string sign = "+";
                Console.WriteLine("B {sign} ");
            }
            else if (x<3)
            {
                string sign = "-";
                Console.WriteLine($"A{sign}");
            }
        }
        else if (grade>=70)
        {
            Console.WriteLine("C");
        }
        else if (grade>=60)
        {
            Console.WriteLine("D");
        }
        else if (grade<60)
        {
            Console.WriteLine("F");
        }
    }
}

        
        
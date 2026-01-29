
namespace demo;
internal class MyClass
{
    static void Main(string[] args)
    {       //7
            int age= int.Parse(Console.ReadLine());  
            if (age < 18)  
            {
                Console.WriteLine("Wait "+( 18 - age)+" years");
            }
            else
            {
                Console.WriteLine(" You are eligible");  
            }
        //6
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        try
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            else { Console.WriteLine("Divide by 0 error"); }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        //5
        int h = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w - i; j++)
            {
                Console.Write(h);
            }
            Console.WriteLine();
        }
        //3
        string n = Console.ReadLine();
        Console.WriteLine(n.Remove(3, 1));
        Console.WriteLine(n.Remove(4, 1));
        Console.WriteLine(n.Remove(5, 1));
        //1
        Console.WriteLine("Hello");
        Console.WriteLine(n);
        //2
        sum(num1, num2);
        divide(num1, num2);
        //4
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int r = int.Parse(Console.ReadLine());
        int no = 0;
        int p = 0;
        while (r > 0 && p < nums.Length)
        {
            if (nums[p] % 2 != 0)
            {
                no = nums[p];
                r--;
            }
            p++;

        }
        Console.WriteLine(no);
    }
    static void sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
    static void divide(int num1, int num2)
    {
        Console.WriteLine(num1 / num2);
    }

}




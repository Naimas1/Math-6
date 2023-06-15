using System;

class Program
{
    private static void Main(string[] args)
    {
        Main(args, Convert.ToString(Console.ReadLine()));
    }

    static void Main(string[] args, string? direction)
    {
        Console.Write("Введіть довжину лінії: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть символ заповнювач: ");
        String fillCharacter = Convert.ToString(Console.ReadLine());

        Console.Write("Введіть напрямок горизонтальної лінії: ");
        Convert.ToString(Console.ReadLine());

        Console.Write("Введіть напрямок вертикальної лінії: ");
        Convert.ToString(Console.ReadLine());

        Console.WriteLine("Лінія:"); 
        Convert.ToString(Console.ReadLine());

        if (Convert.ToString(Console.ReadLine()) == "г")
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillCharacter);
            }
        }
        else if (Convert.ToString(Console.ReadLine()) == "в")
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillCharacter);
            }
        }
        else
        {
            Console.WriteLine("Невірний напрямок лінії.");
        }

        Console.ReadLine();
    }
}
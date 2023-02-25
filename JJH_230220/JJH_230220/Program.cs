using System;

class Program
{
    static void Main(string[] args)
    {
        int user = 10;
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;
        int x = (windowWidth - user.ToString().Length) / 2;
        int y = (windowHeight - 1) / 2;
        Console.SetCursorPosition(x, y);
        Console.Write(user);

        Random random = new Random();
        int newY = random.Next(0, windowHeight);
        int newX = windowWidth - 1;
        int newNumber = user + random.Next(-3, 7);

        Console.SetCursorPosition(newX, newY);
        Console.Write(newNumber);

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    x--;
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.UpArrow:
                    y--;
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
                default:
                    continue;
            }
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(user);

            Console.SetCursorPosition(newX--, newY);
            Console.Write(newNumber);

            //newY = random.Next(0, windowHeight);
            //newNumber = user + random.Next(-3, 8);
            //Console.SetCursorPosition(newX, newY);
            //Console.Write(newNumber);
        }
    }
}

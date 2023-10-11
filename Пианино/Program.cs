ConsoleKeyInfo txt = Console.ReadKey();
Console.WriteLine("\nf1 - 1 октава, f2 - 2 октава");
while (true)
{
    txt = Console.ReadKey(true);
    if (txt.Key == ConsoleKey.F1)
    {
        Console.WriteLine("\n1 октава");
        Console.WriteLine("D1 - C, D2 - D, D3 - E, D4 - F");
        Console.WriteLine("D5 - G, D6 - A, D7 - B, Q - C#");
        Console.WriteLine("W - Eb, E - F#");
        Console.SetCursorPosition(0, 0);
        while (txt.Key != ConsoleKey.F2)
        {
            if (txt.Key == ConsoleKey.D1)
            {
                Console.Beep(1047, 100);
            }
            else if (txt.Key == ConsoleKey.D2)
            {
                Console.Beep(1175, 100);
            }
            else if (txt.Key == ConsoleKey.D3)
            {
                Console.Beep(1319, 100);
            }
            else if (txt.Key == ConsoleKey.D4)
            {
                Console.Beep(1397, 100);
            }
            else if (txt.Key == ConsoleKey.D5)
            {
                Console.Beep(1568, 100);
            }
            else if (txt.Key == ConsoleKey.D6)
            {
                Console.Beep(1760, 100);
            }
            else if (txt.Key == ConsoleKey.D7)
            {
                Console.Beep(1976, 100);
            }
            else if (txt.Key == ConsoleKey.Q)
            {
                Console.Beep(1109, 100);
            }
            else if (txt.Key == ConsoleKey.W)
            {
                Console.Beep(1245, 100);
            }
            else if (txt.Key == ConsoleKey.E)
            {
                Console.Beep(1480, 100);
            }
            txt = Console.ReadKey(true);

        }
        Console.ReadKey();
    }
    if (txt.Key == ConsoleKey.F2)
    {
        Console.WriteLine("\n2 октав");
        Console.WriteLine("D1 - C, D2 - D, D3 - E, D4 - F");
        Console.WriteLine("D5 - G, D6 - A, D7 - B, Q - C#");
        Console.WriteLine("W - Eb, E - F#");
        Console.SetCursorPosition(0, 0);
        while (txt.Key != ConsoleKey.F1)
        {
            if (txt.Key == ConsoleKey.D1)
            {
                Console.Beep(4186, 100);
            }
            else if (txt.Key == ConsoleKey.D2)
            {
                Console.Beep(4699, 100);
            }
            else if (txt.Key == ConsoleKey.D3)
            {
                Console.Beep(5274, 100);
            }
            else if (txt.Key == ConsoleKey.D4)
            {
                Console.Beep(5588, 100);
            }
            else if (txt.Key == ConsoleKey.D5)
            {
                Console.Beep(6272, 100);
            }
            else if (txt.Key == ConsoleKey.D6)
            {
                Console.Beep(7040, 100);
            }
            else if (txt.Key == ConsoleKey.D7)
            {
                Console.Beep(7902, 100);
            }
            else if (txt.Key == ConsoleKey.Q)
            {
                Console.Beep(4435, 100);
            }
            else if (txt.Key == ConsoleKey.W)
            {
                Console.Beep(4976, 100);
            }
            else if (txt.Key == ConsoleKey.E)
            {
                Console.Beep(5920, 100);
            }
            txt = Console.ReadKey(true);
        }
    }
}
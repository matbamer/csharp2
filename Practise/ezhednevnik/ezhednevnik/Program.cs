
internal class Program
{
    static int number;
    static void Main()
    {
        int number = 1;
        
        do
        {
            Console.SetCursorPosition(0, 1);
            
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.RightArrow)
            {
                number++;
                Console.Clear();
                           
                Console.WriteLine("Выбрана дата "+ number + ".10.2023");
                
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                number--;
                Console.Clear();
                Console.WriteLine("Выбрана дата " + number + ".10.2023");
                              
            }
            if (number == 6)
            {
                m1();
            }
            if (number == 7)
            {
                m2();
            }
            if (number == 8)
            {
                m3();
            }
        }
        while (number > 0); 
    }
    static void m1()
    {
        Console.WriteLine("  1.Фильмы");
        Console.WriteLine("  2.Кроссовки");

        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            zametka1();
        }
            
    }
    static void m2()
    {
        Console.WriteLine("  1.плагины");
        Console.WriteLine("  2.Куда слетать");
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            zametka2();
        }
       
    }
    static void m3()
    {
        Console.WriteLine("  1.Чо взять с собой на луну");
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            zametka3();
        }
    }
    //забыл про return
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    static void zametka1()
    {//заметка должна быть по одной на m
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
            if (key.Key == ConsoleKey.Enter)
            {
                return;
            }
            Console.SetCursorPosition(0, position); 
                Console.WriteLine("=>");
                key = Console.ReadKey();
            }
            Console.SetCursorPosition (0, 7);
            if (position == 1)
            {
                Console.WriteLine("Гарри Потер, Криминальное чтиво");
            }
            if (position == 2)
            {
                Console.WriteLine("Монархи-Данки, Риковенс(негеи)");
            }
        Main();
    }//
    static void zametka2()
    {
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        
        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                position++;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                return;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("=>");
            key = Console.ReadKey();
        }
        Console.SetCursorPosition(0, 7);
        if (position == 1)
        {
            Console.WriteLine("омнисфера, контакт, вальхалла");
        }
        else if (position == 2)
        {
            Console.WriteLine("хз, тайланд, венеция, узбекистан");
        }
       
        Main();
    }
    static void zametka3()
    {
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter)

        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                position++;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                return;
            }

            Console.SetCursorPosition(0, position);
            Console.WriteLine("=>");
            key = Console.ReadKey();

        }
        Console.SetCursorPosition(0, 7);
        if (position == 1)
        {
            Console.WriteLine("табуретку");
        }
        Main();
    }
    

}


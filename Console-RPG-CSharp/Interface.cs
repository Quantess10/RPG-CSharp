﻿namespace RPG
{
    class Interface
    {
        public void StartMenu()
        {

            int wybor = -1;
            bool poprawnyWybor = false;

            while (!poprawnyWybor)
            {
                Console.Clear();
                Console.WriteLine("           --------------------------------------------- ");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("          |                     GRA                     |");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("          |                                             |");
                Console.WriteLine("           --------------------------------------------- ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                         1. Nowa gra");
                Console.WriteLine("                         2. Wczytaj grę");
                Console.WriteLine("                         3. Wyjście");
                Console.WriteLine();
                Console.Write("                           Wybór: ");

                wybor = Convert.ToInt32(Console.ReadLine());

                if (wybor == 1 || wybor == 2 || wybor == 3)
                {
                    poprawnyWybor = true;
                }
                else
                {
                    Console.WriteLine("Błędny wybór. Proszę podać cyfrę 1, 2 lub 3.");
                }
            }

            switch (wybor)
            {
                case 1:
                    {
                        NewGame();
                        break;
                    }
                case 2:
                    {
                        LoadGame();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }

        public void NewGame()
        {
            int wybor = -1;
            bool poprawnyWybor = false;

            while (!poprawnyWybor)
            {
                Console.Clear();
                Console.WriteLine("Wybierz swoją postać:");
                Console.WriteLine();
                Console.WriteLine("                                       ▲");
                Console.WriteLine("         _  O             O            O o");
                Console.WriteLine("        | |/|\\|          /|\\|\\        /|\\|");
                Console.WriteLine("        |_| | |           | |/         | ");
                Console.WriteLine("           / \\\t         / \\          / \\");
                Console.WriteLine("       1.Wojownik     2.Łucznik      3.Mag");
                Console.WriteLine();
                Console.WriteLine("4.Powrót");
                Console.WriteLine();
                Console.Write("                  Wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                if (wybor == 1 || wybor == 2 || wybor == 3 || wybor == 4)
                {
                    poprawnyWybor = true;
                }
                else
                {
                    Console.WriteLine("Błędny wybór. Proszę podać cyfrę 1, 2 lub 3.");
                }
            }

            switch (wybor)
            {
                case 1:
                    {
                        Console.WriteLine("wojownik");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("łucznik");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("mag");
                        break;
                    }
                case 4:
                    {
                        StartMenu();
                        break;
                    }
            }
        }

        static void LoadGame()
        {
            Console.WriteLine("wczytaj gre");
        }
    }
}
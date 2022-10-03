namespace Pianinonnono
{
    class Program
    {
        public static int chastota;
        static void Main()
        {

            Boolean check = true;
            do
            {
                Console.WriteLine("Выберите действие:\r\nF1 - начать виртуозную игру\r\nF2 - выйти из программы");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        TheFirstOctave();
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("Вы решили выйти");
                        check = false;
                        break;
                    default: Console.WriteLine("Дурачёк"); break;
                }
            } while (check);
        }
        static void TheFirstOctave()
        {
            Console.WriteLine("Изначальная октава - первая. Нажмите F1 для повышения октавы или F2 для её понижения. Если желаете выйти нажмите F3, F4 Если хотите очистить консоль");
            int[] FirstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            Boolean check = true;
            do
            {
                int[] SubArray;
                int[] NewOctave = FirstOctave;
                FirstOctave = NewOctave;
                SubArray = FirstOctave;
                ConsoleKeyInfo key = Console.ReadKey();


                if (key.Key == ConsoleKey.F1)
                {
                    NewOctave = Array.ConvertAll(SubArray, x => 2 * x);
                    FirstOctave = NewOctave;
                    SubArray = FirstOctave;
                    if (NewOctave[0] == 32) { Console.WriteLine("Контра-октава"); }

                    if (NewOctave[0] == 64 || NewOctave[0] == 65) { Console.WriteLine("Большая октава"); }

                    if (NewOctave[0] == 128 || NewOctave[0] == 130) { Console.WriteLine("Малая октава"); }

                    if (NewOctave[0] == 256 || NewOctave[0] == 261) { Console.WriteLine("Первая октава"); }

                    if (NewOctave[0] == 512 || NewOctave[0] == 522) { Console.WriteLine("Вторая октава"); }

                    if (NewOctave[0] == 1024 || NewOctave[0] == 1044) { Console.WriteLine("Третья октава"); }

                    if (NewOctave[0] == 2048 || NewOctave[0] == 2088) { Console.WriteLine("Четвертая октава"); }

                    if (NewOctave[0] == 4096 || NewOctave[0] == 4176) { Console.WriteLine("Пятая октава"); }


                    if (NewOctave[0] > 4186)
                    {
                        Console.WriteLine("Вы вышли за пределы октав, пожалуйста нажмите F2 чтобы продолжить");
                        Boolean check2 = true;
                        do
                        {
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            switch (key2.Key)
                            {
                                case ConsoleKey.F2:
                                    NewOctave = Array.ConvertAll(SubArray, x => x / 2);
                                    FirstOctave = NewOctave;
                                    SubArray = FirstOctave;
                                    Console.WriteLine("Пятая октава");
                                    check2 = false;
                                    break;
                                default: Console.WriteLine("ВВЕДИТЕ F2"); break;
                            }
                        } while (check2);
                    }


                }


                if (key.Key == ConsoleKey.F2)
                {
                    NewOctave = Array.ConvertAll(SubArray, x => x / 2);
                    FirstOctave = NewOctave;
                    SubArray = FirstOctave;
                    if (NewOctave[0] == 32) { Console.WriteLine("Контра-октава"); }

                    if (NewOctave[0] == 64 || NewOctave[0] == 65) { Console.WriteLine("Большая октава"); }

                    if (NewOctave[0] == 128 || NewOctave[0] == 130) { Console.WriteLine("Малая октава"); }

                    if (NewOctave[0] == 256 || NewOctave[0] == 261) { Console.WriteLine("Первая октава"); }

                    if (NewOctave[0] == 512 || NewOctave[0] == 522) { Console.WriteLine("Вторая октава"); }

                    if (NewOctave[0] == 1024 || NewOctave[0] == 1044) { Console.WriteLine("Третья октава"); }

                    if (NewOctave[0] == 2048 || NewOctave[0] == 2088) { Console.WriteLine("Четвертая октава"); }

                    if (NewOctave[0] == 4096 || NewOctave[0] == 4176) { Console.WriteLine("Пятая октава"); }

                    if (NewOctave[0] < 32)
                    {
                        Console.WriteLine("Вы вышли за пределы октав, пожалуйста нажмите F1 чтобы продолжить");
                        Boolean check2 = true;
                        do
                        {
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            switch (key2.Key)
                            {
                                case ConsoleKey.F1:
                                    NewOctave = Array.ConvertAll(SubArray, x => x * 2);
                                    FirstOctave = NewOctave;
                                    SubArray = FirstOctave;
                                    Console.WriteLine("Контра-октава");
                                    check2 = false;
                                    break;
                                default: Console.WriteLine("ВВЕДИТЕ F1"); break;
                            }
                        } while (check2);
                    }


                }

                if (key.Key == ConsoleKey.F3)
                {
                    check = false;
                }
                if (key.Key == ConsoleKey.F4)
                {
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Z)
                {
                    chastota = NewOctave[0];
                    Beep();
                }
                if (key.Key == ConsoleKey.A)
                {
                    chastota = NewOctave[1];
                    Beep();
                }
                if (key.Key == ConsoleKey.X)
                {
                    chastota = NewOctave[2];
                    Beep();
                }
                if (key.Key == ConsoleKey.D)
                {
                    chastota = NewOctave[3];
                    Beep();
                }
                if (key.Key == ConsoleKey.C)
                {
                    chastota = NewOctave[4];
                    Beep();
                }
                if (key.Key == ConsoleKey.V)
                {
                    chastota = NewOctave[5];
                    Beep();
                }
                if (key.Key == ConsoleKey.F)
                {
                    chastota = NewOctave[6];
                    Beep();
                }
                if (key.Key == ConsoleKey.B)
                {
                    chastota = NewOctave[7];
                    Beep();
                }
                if (key.Key == ConsoleKey.G)
                {
                    chastota = NewOctave[8];
                    Beep();
                }
                if (key.Key == ConsoleKey.N)
                {
                    chastota = NewOctave[9];
                    Beep();
                }
                if (key.Key == ConsoleKey.J)
                {
                    chastota = NewOctave[10];
                    Beep();
                }
                if (key.Key == ConsoleKey.M)
                {
                    chastota = NewOctave[11];
                    Beep();
                }
            } while (check);
        }
        static void Beep()
        {
            Console.Beep(chastota, 400);
            Console.Clear();
        }
    }
}
using Task_Done.Main;

int idx = 0;
char[] arr = { '>', ' ', ' ', ' ' };

void Swap(ref char sym1, ref char sym2) =>
    (sym1, sym2) = (sym2, sym1);


PetShop petShop = new PetShop();

do
{
    Console.WriteLine("Kategotia Secin");
    Console.WriteLine($"{arr[0]} Cat");
    Console.WriteLine($"{arr[1]} Dog");
    Console.WriteLine($"{arr[2]} Fish");
    Console.WriteLine($"{arr[3]} Bird");

    var keyInfo = Console.ReadKey();

    Console.Clear();

    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        if (idx < 3)
            Swap(ref arr[idx], ref arr[++idx]);
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        if (idx > 0)
            Swap(ref arr[idx], ref arr[--idx]);
    }
    else if (keyInfo.Key == ConsoleKey.Enter)
    {
        switch (idx)
        {
            case 0:

                char[] menu1 = new char[petShop.Cats.Length];

                for (int i = 0; i < menu1.Length; i++)
                {
                    menu1[i] = ' ';
                }

                menu1[0] = '>';
                int catIndex = 0;

                do
                {
                    for (int i = 0; i < petShop.Cats.Length; i++)
                    {
                        Console.WriteLine($"{menu1[i]} {petShop.Cats[i].Nickname}");
                    }

                    var keyInfo1 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo1.Key == ConsoleKey.DownArrow)
                    {
                        if (catIndex < menu1.Length - 1)
                            Swap(ref menu1[catIndex], ref menu1[++catIndex]);
                    }
                    else if (keyInfo1.Key == ConsoleKey.UpArrow)
                    {
                        if (catIndex > 0)
                            Swap(ref menu1[catIndex], ref menu1[--catIndex]);
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        char[] arr2 = { '>', ' ', ' ', ' ' };
                        int idx2 = 0;

                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr2[0]} Info");
                            Console.WriteLine($"{arr2[1]} Eat");
                            Console.WriteLine($"{arr2[2]} Sleep");
                            Console.WriteLine($"{arr2[3]} Play");

                            var keyInfo2 = Console.ReadKey();

                            Console.Clear();

                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (idx2 < 3)
                                    Swap(ref arr2[idx2], ref arr2[++idx2]);
                            }
                            else if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (idx2 > 0)
                                    Swap(ref arr2[idx2], ref arr2[--idx2]);
                            }
                            else if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                Cat cat = petShop.Cats[catIndex];

                                switch (idx2)
                                {
                                    case 0:
                                        Console.Clear();
                                        Console.WriteLine(cat);
                                        break;
                                    case 1:
                                        cat.Eat();
                                        break;
                                    case 2:
                                        cat.Sleep();
                                        break;
                                    case 3:
                                        cat.Play();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            case 1:
                char[] menu2 = new char[petShop.Dogs.Length];

                for (int i = 0; i < menu2.Length; i++)
                {
                    menu2[i] = ' ';
                }

                menu2[0] = '>';
                int dogIndex = 0;

                do
                {
                    for (int i = 0; i < petShop.Dogs.Length; i++)
                    {
                        Console.WriteLine($"{menu2[i]} {petShop.Dogs[i].Nickname}");
                    }

                    var keyInfo3 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo3.Key == ConsoleKey.DownArrow)
                    {
                        if (dogIndex < menu2.Length - 1)
                            Swap(ref menu2[dogIndex], ref menu2[++dogIndex]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.UpArrow)
                    {
                        if (dogIndex > 0)
                            Swap(ref menu2[dogIndex], ref menu2[--dogIndex]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.Enter)
                    {
                        char[] arr3 = { '>', ' ', ' ', ' ' };
                        int idx4 = 0;

                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr3[0]} Info");
                            Console.WriteLine($"{arr3[1]} Eat");
                            Console.WriteLine($"{arr3[2]} Sleep");
                            Console.WriteLine($"{arr3[3]} Play");

                            var keyInfo4 = Console.ReadKey();

                            Console.Clear();

                            if (keyInfo4.Key == ConsoleKey.DownArrow)
                            {
                                if (idx4 < 3)
                                    Swap(ref arr3[idx4], ref arr3[++idx4]);
                            }
                            else if (keyInfo4.Key == ConsoleKey.UpArrow)
                            {
                                if (idx4 > 0)
                                    Swap(ref arr3[idx4], ref arr3[--idx4]);
                            }
                            else if (keyInfo4.Key == ConsoleKey.Enter)
                            {
                                Dog dog = petShop.Dogs[dogIndex];

                                switch (idx4)
                                {
                                    case 0:
                                        Console.Clear();
                                        petShop.dogInfo();
                                        break;
                                    case 1:
                                        dog.Eat();
                                        break;
                                    case 2:
                                        dog.Sleep();
                                        break;
                                    case 3:
                                        dog.Play();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            case 2:
                char[] menu3 = new char[petShop.Fishes.Length];
                for (int i = 0; i < menu3.Length; i++)
                {
                    menu3[i] = ' ';
                }
                menu3[0] = '>';
                int fishIndex = 0;
                do
                {
                    for (int i = 0; i < petShop.Fishes.Length; i++)
                    {
                        Console.WriteLine($"{menu3[i]} {petShop.Fishes[i].Nickname}");
                    }
                    var keyInfo4 = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo4.Key == ConsoleKey.DownArrow)
                    {
                        if (fishIndex < menu3.Length - 1)
                            Swap(ref menu3[fishIndex], ref menu3[++fishIndex]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.UpArrow)
                    {
                        if (fishIndex > 0)
                            Swap(ref menu3[fishIndex], ref menu3[--fishIndex]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.Enter)
                    {
                        char[] arr4 = { '>', ' ', ' ', ' ' };
                        int idx6 = 0;
                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr4[0]} Info");
                            Console.WriteLine($"{arr4[1]} Eat");
                            Console.WriteLine($"{arr4[2]} Sleep");
                            Console.WriteLine($"{arr4[3]} Play");
                            var keyInfo5 = Console.ReadKey();
                            Console.Clear();
                            if (keyInfo5.Key == ConsoleKey.DownArrow)
                            {
                                if (idx6 < 3)
                                    Swap(ref arr4[idx6], ref arr4[++idx6]);
                            }
                            else if (keyInfo5.Key == ConsoleKey.UpArrow)
                            {
                                if (idx6 > 0)
                                    Swap(ref arr4[idx6], ref arr4[--idx6]);
                            }
                            else if (keyInfo5.Key == ConsoleKey.Enter)
                            {
                                Fish fish = petShop.Fishes[fishIndex];
                                switch (idx6)
                                {
                                    case 0:
                                        Console.Clear();
                                        petShop.fishInfo();
                                        break;
                                    case 1:
                                        fish.Eat();
                                        break;
                                    case 2:
                                        fish.Sleep();
                                        break;
                                    case 3:
                                        fish.Play();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            case 3:
                char[] menu4 = new char[petShop.Birds.Length];
                for (int i = 0; i < menu4.Length; i++)
                {
                    menu4[i] = ' ';
                }
                menu4[0] = '>';
                int birdIndex = 0;
                do
                {
                    for (int i = 0; i < petShop.Birds.Length; i++)
                    {
                        Console.WriteLine($"{menu4[i]} {petShop.Birds[i].Nickname}");
                    }
                    var keyInfo6 = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo6.Key == ConsoleKey.DownArrow)
                    {
                        if (birdIndex < menu4.Length - 1)
                            Swap(ref menu4[birdIndex], ref menu4[++birdIndex]);
                    }
                    else if (keyInfo6.Key == ConsoleKey.UpArrow)
                    {
                        if (birdIndex > 0)
                            Swap(ref menu4[birdIndex], ref menu4[--birdIndex]);
                    }
                    else if (keyInfo6.Key == ConsoleKey.Enter)
                    {
                        char[] arr5 = { '>', ' ', ' ', ' ' };
                        int idx8 = 0;
                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr5[0]} Info");
                            Console.WriteLine($"{arr5[1]} Eat");
                            Console.WriteLine($"{arr5[2]} Sleep");
                            Console.WriteLine($"{arr5[3]} Play");
                            var keyInfo7 = Console.ReadKey();
                            Console.Clear();
                            if (keyInfo7.Key == ConsoleKey.DownArrow)
                            {
                                if (idx8 < 3)
                                    Swap(ref arr5[idx8], ref arr5[++idx8]);
                            }
                            else if (keyInfo7.Key == ConsoleKey.UpArrow)
                            {
                                if (idx8 > 0)
                                    Swap(ref arr5[idx8], ref arr5[--idx8]);
                            }
                            else if (keyInfo7.Key == ConsoleKey.Enter)
                            {
                                Bird bird = petShop.Birds[birdIndex];
                                switch (idx8)
                                {
                                    case 0:
                                        Console.Clear();
                                        petShop.birdInfo();
                                        break;
                                    case 1:
                                        bird.Eat();
                                        break;
                                    case 2:
                                        bird.Sleep();
                                        break;
                                    case 3:
                                        bird.Play();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            default:
                break;
        }
    }

} while (true);




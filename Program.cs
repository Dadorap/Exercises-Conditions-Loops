using System.Security;
using System.Security.Cryptography;

namespace Exercises_Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övningar 1
            //Console.Write("Enter a number: ");
            //int tal = int.Parse(Console.ReadLine());
            //if (tal >= 0)
            //{
            //    Console.WriteLine("you'v enterd a positiv number");
            //}
            //else
            //{
            //    Console.WriteLine("you'v enterd a negativ number");
            //}

            //Övningar 2
            //Console.Write("Enter a number: ");
            //int tal1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int tal2 = int.Parse(Console.ReadLine());

            //if (tal1 < tal2)
            //{
            //    Console.WriteLine("{tal1} is smaller then {tal2}");
            //}
            //else if(tal1 > tal2){
            //    Console.WriteLine($"{tal1} is bigger then {tal2}");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            // Övningar 3
            //Console.Write("Enter a number: ");
            //double tal1 = Convert.ToDouble(Console.ReadLine());
            //double tal2 = 0;
            //if ( tal1 >0 )
            //{
            //Console.Write("Enter a number: ");
            // tal2 = Convert.ToDouble(Console.ReadLine());
            //}
            //Console.WriteLine( $"{tal1}/{tal2} = {tal1/tal2}");

            // övning 4
            //int playersNumber = -1;

            //while(playersNumber < 0 || playersNumber > 10)
            //{
            //    //Console.WriteLine($"well done! you number was: {playersNumber}");
            //    Console.Write("Enter a number between 0 and 10: ");

            //    string playerResp = Console.ReadLine();
            //    playersNumber = int.Parse(playerResp);
            //}

            //Console.WriteLine($"well done! you number was: {playersNumber}");

            //5 for loop övning
            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col <= row; col++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}

            // övning 5
            //Console.Write("Enter a number: ");
            //int tal1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int tal2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int tal3 = int.Parse(Console.ReadLine());

            //if(tal1 > tal2 && tal1 > tal3)
            //{
            //    Console.WriteLine($"största talet är: {tal1}");
            //}
            //else if(tal2 > tal1 && tal2 > tal3)
            //{
            //    Console.WriteLine($"största talet är: {tal2}");
            //} else if(tal3 > tal1 && tal3 > tal2)
            //{
            //    Console.WriteLine($"största talet är: {tal3}");

            //}
            //else if (tal1.Equals(tal2) && tal1.Equals(tal3)) 
            //{
            //    Console.WriteLine(":O");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            // övning 6
            //Console.Write("Enter a number: ");
            //int tal1 = int.Parse(Console.ReadLine());

            //if ( tal1 > 10 )
            //{
            //    Console.WriteLine(tal1 +" är större än 10");
            //}else if( tal1 < 10 )
            //{
            //    Console.WriteLine(tal1 + " är mindre än 10");
            //}
            //else
            //{
            //    Console.WriteLine(tal1 + " är lika med 10");

            //}

            // övning 7
            //Console.Write("Enter a temp: ");
            //int temp = int.Parse(Console.ReadLine());

            //if (temp < -10)
            //{
            //    Console.WriteLine("Det är jättekallt!");
            //}
            //else if (temp >= -10 && temp < 0)
            //{
            //    Console.WriteLine("Det är kallt!");
            //}
            //else if (temp >= 0 && temp < 10)
            //{
            //    Console.WriteLine("Det är milt");
            //}
            //else if (temp >= 10 && temp < 20)
            //{
            //    Console.WriteLine("Det är lagom");

            //}
            //else if (temp >= 20 && temp < 30)
            //{
            //    Console.WriteLine("Det är varmt!");
            //}
            //else
            //{
            //    Console.WriteLine("Hjälp! Jag smälter!");
            //}

            //  Loops
            // övning 8
            //int x = 0;
            //while(x <= 30)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            // övning 9
            //int x = 15;
            //while (x >= -5)
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}

            // övning 10
            //int x = 0;
            //while (x <= 45)
            //{
            //    if(x % 3 == 0)
            //        Console.WriteLine(x);
            //    x++;
            //}

            // övning 11
            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x >= 100);

            // övning 12
            //for (int i = -5; i <= 23 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // övning 13
            //for (int i = -10; i >= -40; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // övning 14
            //for(int i =-30; i<= -10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //övning 15
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //övning 16
            //Console.Write("Enter a number: ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= x; i++)
            //{
            //    Console.Write(x);
            //}

            // övning 17
            //for (int i = 0; i <= 30; i++)
            //{
            //    if (i == 3 || i == 15 || i == 27)
            //    {
            //        Console.WriteLine("hey");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            // övning 18
            //Console.Write("Enter a number");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 40; i <= 70; i++)
            //{
            //    if (i == x)
            //    {
            //        Console.WriteLine();
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            // övning 19
            // int x = 15;
            //while (x >= 7)
            // {
            //     if(x % 2 == 1)
            //     {
            //     Console.WriteLine(x);
            //     }
            //     x--;
            // }

            // övning 20
            //while (true)
            //  {
            //      Console.Write("Enter a text: ");
            //      string x = Console.ReadLine();
            //      Console.WriteLine(x);
            //      if (x =="sluta")
            //      {
            //          break;
            //      }
            //  }

            // övning 22
            //int rng = new Random().Next(1, 50);
            //int counter = 5;
            //while (counter >= 1)
            //{
            //    Console.Write($"Enter a number between 1 - 5 you have {counter} attempt: ");
            //    int x = int.Parse(Console.ReadLine());

            //    if (x < rng)
            //    {
            //        Console.WriteLine($"To low ");
            //        counter--;
            //    }
            //    else if (x > rng )
            //    {
            //        Console.WriteLine($"To high ");
            //        counter--;
            //    }
            //    else if (x == rng)
            //    {
            //        Console.WriteLine("Congratz");
            //        break;
            //    }
            //}
            //if (counter == 0)
            //{
            //    Console.WriteLine("You'v lost!");
            //}

            // övning 23
            int rows = 5;

            // Endast en loop för att skapa hela mönstret
            for (int i = 1; i < 10; i++)
            {
                // Om vi är på de första 5 raderna (uppåtgående del)
                //if (i <= rows)eeeeeeeeeeeeeeeeeeeeeeeeeeeee
                //{
                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //}
                // Om vi är på de sista 4 raderna (nedåtgående del)
             
                    for (int j = 1; j <= (5 - i); j++)
                    {
                        Console.Write("*");
                    }
                

                Console.WriteLine();
            }
        }
    }
}

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Random randomizer = new Random();

        Assigment1(randomizer); 
        Assigment2(randomizer);
        Assigment3(randomizer, 6, 2);
        Assigment4(randomizer);
    }

    static void Assigment1(Random randomizer) {
        for (int i = 0; i < 100; i++) {
            Console.Write(randomizer.Next(1, 101) + " ");
        }
    }

    static void Assigment2(Random randomizer) {
        int mysteryNumber = randomizer.Next(1, 101); 
        int tries = 0;
        
        Console.WriteLine("Guess the secret number between 1 - 100");
         
        while (true) {
            Console.Write(": "); 
            int guess = Convert.ToInt32(Console.ReadLine()); 
            
            if (guess > mysteryNumber) {
                Console.WriteLine("Guess lower !"); 
            } else if (guess < mysteryNumber) {
                Console.WriteLine("Guess higher !");
            } else {
                Console.WriteLine($"Correct ! It took you {tries} tries to guess the mystery number.");
                break;
            }

            tries++;
        }
    }

    static void Assigment3(Random randomizer, int faces, int throws) {
        for (int i = 1; i <= throws; i++) {
            int value = randomizer.Next(1, faces + 1);
            Console.WriteLine($"Throw {i}: {value}"); 
        }
    }

    static void Assigment4(Random randomizer) {
        // Det fungerar, men jag vet inte hur man gör om man har string? dice. 

        Console.WriteLine("Enter dice example (2t6, 12t20, 4t7 ect...): "); 

        string dice = Console.ReadLine(); 
        string[] components = dice.Split("t"); 

        int throws = int.Parse(components[0]);
        int faces = int.Parse(components[1]);

        Assigment3(randomizer, faces, throws);
    }
}
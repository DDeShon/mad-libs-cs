using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            string theMatrix, system, neo, enemy, inside, save, unplugged, fight;
            string[] profession = new string[4], adj = new string[2];

            // Get User Input
            Console.WriteLine("Hello user!");
            Console.WriteLine("Let's play a game of madlibs!");
            Console.WriteLine("Please enter your name.");
            neo = Console.ReadLine();

            // Get theMatrix variable from user
            Console.WriteLine($"Hello {neo}! Let's begin. What is something that you want to know more about?");
            theMatrix = Console.ReadLine();

            // Get system variable from user
            Console.WriteLine($"So you want to know more about {theMatrix}, do you?");
            Console.WriteLine($"First, tell me what you already know about {theMatrix}.");
            Console.WriteLine($"What noun would you best use to describe {theMatrix}?");
            system = Console.ReadLine();

            // Get enemy variable from user
            Console.WriteLine($"Please provide me with another noun, in opposition to {system}.");
            enemy = Console.ReadLine();

            // Get inside variable from user
            Console.WriteLine("Please tell me your favorite place to relax.");
            inside = Console.ReadLine();

            // Get profession list from user
            Console.WriteLine("What are the top 4 jobs that you would most like to have?");

            for (int i = 0; i < profession.length; i++)
            {
                Console.WriteLine($"Profession {i + 1} / {profession.length}: ");
                profession[i] = Console.ReadLine();
            }

            // Get save variable from user
            Console.WriteLine("Now, please provide me with a verb to provide action for our story.");
            save = Console.ReadLine();

            // Get unplugged variable from user
            Console.WriteLine("We're nearing the end now. Please give me another verb.");
            unplugged = Console.ReadLine();

            // Get adjectives from user
            Console.WriteLine("Please provide me with 2 descriptive adjectives.");

            for (int i = 0; i < adj.length; i++)
            {
                Console.WriteLine($"Adjective {i + 1} / {adj.length}: ");
                adj[i] = Console.ReadLine();
            }

            // Get fight variable from user
            Console.WriteLine("The end is finally here. Please provide one final verb, to wrap up the story.")
            fight = Console.ReadLine();

            // Init Story
            string madlibsStory =
            $"{theMatrix} is a {system}, {Neo}. That {system} is our {enemy}. " +
            $"But when you're {inside}, you look around, what do you see? " +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}. The very minds " +
            $"of the people we are trying to {save}. But until we do, " +
            $"these people are still a part of that {system} and that makes " +
            $"them our {enemy}. You have to understand, most of these people " +
            $"are not ready to be {unplugged}. And many of them are so {adj[0]}, " +
            $"so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.";

            // Print Story
            Console.WriteLine(madlibsStory);
            Console.ReadKey();
        }
    }
}
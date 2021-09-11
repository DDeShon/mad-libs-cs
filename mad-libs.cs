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
            
            Console.WriteLine($"Hello {neo}! Let's begin. What is something that you want to know more about?");
            theMatrix = Console.ReadLine();

            Console.WriteLine($"So you want to know more about {theMatrix}, do you?");
            Console.WriteLine($"First, tell me what you already know about {theMatrix}.");
            Console.WriteLine($"What noun would you best use to describe {theMatrix}?");
            system = Console.ReadLine();

            Console.WriteLine($"Please provide me with another noun, in opposition to {system}.");
            Console.ReadLine();

            

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
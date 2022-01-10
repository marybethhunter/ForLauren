using System;

namespace ForLauren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh hey...");
            Console.ReadKey();
            Console.WriteLine("You might be thinking... What even is this?");
            Console.ReadKey();
            Console.WriteLine("Is my girlfriend a hacker?");
            Console.ReadKey();
            Console.WriteLine("I'm scared...");
            Console.ReadKey();
            Console.WriteLine("Well I'm here to tell you today that there ain't no reason to be scared. Copyright Grasshopper 2021.");
            Console.ReadKey();
            Console.WriteLine("Now tell me little lady... how are you feeling today on a scale of 1-5 (1 being the worst, 5 being the best)?");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("What do you need from me right now? Can I help you do or with anything? I love you and am here for you always.");
            } 
            if (input == 2)
            {
                Console.WriteLine("What do you need from me right now? Can I help you do or with anything? I love you and am here for you always");
            }
            if (input == 3)
            {
                Console.WriteLine("Do you want to go get coffee and go for a walk or stay in? What do you feel more aligned with today?");
            }
            if (input == 4)
            {
                Console.WriteLine("I'm so glad you're having a great day, my love. Want to tell me about it while I cook dinner?");
            }
            if (input == 5)
            {
                Console.WriteLine("Hell yeah!! What could we do to keep vibin' these vibes??");
            }

            var input2 = Console.ReadLine();

            Console.WriteLine($"Your answer: {input2}. I'm here for it. ILYSM.");
        }
    }
}

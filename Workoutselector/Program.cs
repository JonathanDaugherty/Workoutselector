using System;

namespace Workoutselector
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int reps1 = r.Next(15, 25);
            int reps2 = r.Next(15, 25);
            int reps3 = r.Next(15, 25);
            int rounds = r.Next(3, 6);

            Console.WriteLine($"Workout will be {rounds} rounds of: ");
            Console.WriteLine($"Push-ups:{reps1} reps");
            Console.WriteLine($"Sit-ups:{reps2} reps");
            Console.WriteLine($"Air-Squats:{reps3} reps");
        }
    }
}

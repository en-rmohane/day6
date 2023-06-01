using System;
using System.Diagnostics;

class StopwatchProgram
{
    static void Main()
    {
        Console.WriteLine("Press any key to start the stopwatch...");
        Console.ReadKey();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("Stopwatch started. Press any key to stop...");
        Console.ReadKey();

        stopwatch.Stop();

        TimeSpan elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Elapsed Time: {elapsedTime}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

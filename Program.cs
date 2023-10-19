using System;
class Program
{
    static double[] octave1 = { 261.63, 293.66, 329.63, 349.23, 392.00, 440.00, 493.88 };
    static double[] octave2 = { 523.25, 587.33, 659.25, 698.46, 783.99, 880.00, 987.77 };
    static double[] octave3 = { 1046.50, 1174.66, 1318.51, 1396.91, 1567.98, 1760.00, 1975.53 };

    static double[] currentOctave = octave1;

    static void Main()
    {
        bool running = true;

        Console.WriteLine("Добро пожаловать в пианино.");

        Console.WriteLine("Нажмите Q, чтобы выйти.");

        while (running)
        {
            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    currentOctave = octave1;
                    break;
                case '2':
                    currentOctave = octave2;
                    break;
                case '3':
                    currentOctave = octave3;
                    break;
                case 'Q':
                case 'q':
                    running = false;
                    break;
                default:
                    break;
            }

            if (running)
            {
                while (Console.KeyAvailable == false)
                {

                }

                char key = Console.ReadKey(true).KeyChar;

                switch (key)
                {
                    case 'A':
                    case 'a':
                        PlaySound(currentOctave[0]);
                        break;
                    case 'B':
                    case 'b':
                        PlaySound(currentOctave[1]);
                        break;
                    case 'C':
                    case 'c':
                        PlaySound(currentOctave[2]);
                        break;
                    case 'D':
                    case 'd':
                        PlaySound(currentOctave[3]);
                        break;
                    case 'E':
                    case 'e':
                        PlaySound(currentOctave[4]);
                        break;
                    case 'F':
                    case 'f':
                        PlaySound(currentOctave[5]);
                        break;
                    case 'G':
                    case 'g':
                        PlaySound(currentOctave[6]);
                        break;
                    case 'H':
                    case 'h':
                        PlaySharpSound(currentOctave[0]);
                        break;
                    case 'J':
                    case 'j':
                        PlaySharpSound(currentOctave[2]);
                        break;
                    case 'Q':
                    case 'q':
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
    static void PlaySound(double frequency)
    {
        Console.Beep((int)frequency, 500); 
    }
    static void PlaySharpSound(double frequency)
    {
        Console.Beep((int)frequency, 250); 
    }
}
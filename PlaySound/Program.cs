using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlaySound
{
    class Program
    {
        static void Main(string[] args)
        {
            Player.Instance.Add("demo", "demoMp3.wav");
            new Task(() =>
            {
                Console.WriteLine("Playing in background thread.");
                Player.Instance.Play("demo");
            }).Start();

            Console.WriteLine("Play sound.");
            Console.ReadLine();
        }
    }
}

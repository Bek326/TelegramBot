using System;
using TelegramBot;
using TelegramBot.Commands;
using TelegramBot.EnglishTrainer.Model;

namespace TelegramBot
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            var bot = new BotWorker();

            bot.Inizalize();
            bot.Start();

            Console.WriteLine("Напишите stop для прекращения работы");

            string command;
            do
            {
                command = Console.ReadLine();

            } while (command != "stop");

            bot.Stop();

        }
    }
}

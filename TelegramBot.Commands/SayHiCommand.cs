using System;
using TelegramBot.Commands;
using TelegramBot.EnglishTrainer.Model;
namespace Commands
{
    public class SayHiCommand : AbstractCommand, IChatTextCommand
    {
        public SayHiCommand()
        {
            CommandText = "/saymehi";
        }

        public string ReturnText()
        {
            return "привет";
        }

    }
}

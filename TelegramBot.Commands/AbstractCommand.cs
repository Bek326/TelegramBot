using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.Commands;
using TelegramBot;
using TelegramBot.EnglishTrainer.Model;

namespace TelegramBot.Commands
{
    public abstract class AbstractCommand: IChatCommand
    {
        public string CommandText;

        public virtual bool CheckMessage(string message)
        {
            return CommandText == message;
        }
    }
}

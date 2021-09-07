﻿using System;
using TelegramBot;
using TelegramBot.EnglishTrainer.Model;
using TelegramBot.Commands;

namespace Commands
{
    public class DeleteWordCommand : ChatTextCommandOption, IChatTextCommandWithAction
    {
        public DeleteWordCommand()
        {
            CommandText = "/deleteword";
        }

        public bool DoAction(Conversation chat)
        {
            var message = chat.GetLastMessage();

            var text = ClearMessageFromCommand(message);

            if (chat.dictionary.ContainsKey(text))
            {
                chat.dictionary.Remove(text);
                return true;
            }

            return false;
        }

        public string ReturnText()
        {
            return "Слово успешно удалено!";
        }
    }
}

using Commands;

namespace TelegramBot.Commands
{
    public interface IChatTextCommandWithAction : IChatTextCommand
    {
        bool DoAction(Conversation chat);
    }
}

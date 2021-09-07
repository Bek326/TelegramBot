namespace TelegramBot.Commands
{
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }
}

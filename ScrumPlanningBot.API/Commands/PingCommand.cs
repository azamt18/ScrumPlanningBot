using System.Threading.Tasks;
using ScrumPlanningBot.Application;

namespace ScrumPlanningBot.API.Commands
{
    public class PingCommand : IBotCommand
    {
        public string Command => "ping";

        public string Description => "This is a simple command that can be used to test if the bot is online";

        public bool InternalCommand => false;

        public async Task Execute(IChatService chatService, long chatId, long userId, int messageId,
            string? commandText)
        {
            var x = commandText;
            await chatService.SendMessage(chatId, "pong");
        }
    }
}
using System.Threading.Tasks;
using ScrumPlanningBot.Application;

namespace ScrumPlanningBot.API.Commands
{
    public class NewRoomCommand : IBotCommand
    {
        public string Command => "newroom";

        public string Description => "Create a new room";

        public bool InternalCommand => false;

        public async Task Execute(IChatService chatService, long chatId, long userId, int messageId,
            string? commandText)
        {
            await chatService.SendMessage(chatId, "Send a title for an instant room");
        }
    }
}
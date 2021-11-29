using System.Threading.Tasks;
using ScrumPlanningBot.Application;

namespace ScrumPlanningBot.API.Commands
{
    public interface IBotCommand
    {
        string Command { get; }
        string Description { get; }
        bool InternalCommand { get; }

        Task Execute(IChatService chatService, long chatId, long userId, int messageId, string? commandText);
    }
}

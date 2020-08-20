using System.Threading.Tasks;
using Claims.Alerts.WebApi.Models;

namespace Claims.Alerts.WebApi.Hubs
{
    /// <summary>
    /// Interface used to define method on the hub that can be
    /// called to send logs messages to all connected clients.
    /// </summary>
    public interface IMessageLogHub
    {
        Task LogMessage(MessageLogModel messageLog);
    }
}
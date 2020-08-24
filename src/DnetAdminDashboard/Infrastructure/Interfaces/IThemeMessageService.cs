using System;
using DnetAdminDashboard.Infrastructure.Models;

namespace DnetAdminDashboard.Infrastructure.Interfaces
{
    public interface IThemeMessageService<T>
    {
        event Action<ActionMessage<T>> OnMessage;

        void SendMessage(ActionMessage<T> actionMessage);
    }
}

using System;
using DnetAdminDashboard.Infrastructure.Interfaces;
using DnetAdminDashboard.Infrastructure.Models;

namespace DnetAdminDashboard.Infrastructure.Services
{
    public class ThemeMessageService<T>: IThemeMessageService<T>
    {
        public event Action<ActionMessage<T>> OnMessage;

        public void SendMessage(ActionMessage<T> actionMessage)
        {
            OnMessage?.Invoke(actionMessage);
        }

    }
}

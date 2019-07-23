using System;

namespace BlazorAdminDashboard.Client.Shared.Theme
{
    public interface IThemeMessageService<T>
    {
        void SendMessage(ActionMessage<T> message);

        IObservable<ActionMessage<T>> GetMessage();
    }
}

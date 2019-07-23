using System;

namespace BlazorTestApp.Shared.Theme
{
    public interface IThemeMessageService<T>
    {
        void SendMessage(ActionMessage<T> message);

        IObservable<ActionMessage<T>> GetMessage();
    }
}

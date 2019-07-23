using System;
using System.Reactive.Subjects;

namespace BlazorTestApp.Shared.Theme
{
    public class ThemeMessageService<T>: IThemeMessageService<T>
    {
        private readonly Subject<ActionMessage<T>> _subject = new Subject<ActionMessage<T>>();

        public void SendMessage(ActionMessage<T> message) => _subject.OnNext(message);

        public IObservable<ActionMessage<T>> GetMessage() => _subject;

    }
}

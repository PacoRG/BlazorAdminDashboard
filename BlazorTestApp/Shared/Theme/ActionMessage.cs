namespace BlazorTestApp.Shared.Theme
{
    public class ActionMessage<T>
    {
        public ThemeMessageEmitter Emitter { get; set; }
        public T Data { get; set; }
    }
}

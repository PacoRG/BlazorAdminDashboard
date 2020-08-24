using DnetAdminDashboard.Infrastructure.Enums;

namespace DnetAdminDashboard.Infrastructure.Models
{
    public class ActionMessage<T>
    {
        public ThemeMessageEmitter Emitter { get; set; }
        public T Data { get; set; }
    }
}

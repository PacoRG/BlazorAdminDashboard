using System.Collections.Generic;

namespace BlazorTestApp.Shared.Theme.DesktopNavigation
{
    public class NavigationMenu
    {

        public int MenuId { get; set; }

        public int ParentId { get; set; }

        public bool IsNode { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        public string Redirect { get; set; }

        public string Title { get; set; }

        public string IconClass { get; set; }

        public List<NavigationMenu> Children { get; set; }

        public List<string> Rights { get; set; }
    }
}

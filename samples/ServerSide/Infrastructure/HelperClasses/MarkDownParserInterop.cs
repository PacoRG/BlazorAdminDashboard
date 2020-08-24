using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ServerSide.Infrastructure.HelperClasses
{
    public static class MarkDownParserInterop
    {
        public static ValueTask<string> ParseMarkdown(IJSRuntime jsRuntime, string markDown)
            => jsRuntime.InvokeAsync<string>("markdownparser.parseMarkdown", markDown);
    }
}

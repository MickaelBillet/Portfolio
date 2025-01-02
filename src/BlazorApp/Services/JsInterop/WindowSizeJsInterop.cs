using BlazorApp.Components;
using Microsoft.JSInterop;

namespace BlazorApp.Services.JsInterop
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class WindowSizeJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public WindowSizeJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./scripts/windowsize/WindowSize.js").AsTask());

        }

        public async ValueTask<int> GetWindowWidth()
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<int>("GetInnerWidth");
        }

        public async ValueTask<int> GetWindowHeight()
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<int>("GetInnerHeight");
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.InvokeVoidAsync("UnRegisterResizeCallback");
                await module.DisposeAsync();
            }
        }

        public async ValueTask RegisterResizeCallback(DotNetObjectReference<SkillComponent> dotNetObjectReference)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("RegisterResizeCallback", dotNetObjectReference);
        }
    }
}
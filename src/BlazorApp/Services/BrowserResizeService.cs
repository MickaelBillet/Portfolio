using Microsoft.JSInterop;
using BlazorApp.Services.JsInterop;
using BlazorApp.Components;

namespace BlazorApp.Services
{
    public class BrowserResizeService : IAsyncDisposable
    {
        #region Service
        private IJSRuntime JSRuntime { get; }
        private WindowSizeJsInterop WindowSizeJsInterop { get; }
        #endregion

        #region Constructor
        public BrowserResizeService(IJSRuntime runtime) 
        {
            this.JSRuntime = runtime;
            this.WindowSizeJsInterop = new WindowSizeJsInterop(this.JSRuntime);
        }
        #endregion

        #region Methods
        public async Task<int> GetWindowWidthAsync() 
        {
            return await this.WindowSizeJsInterop.GetWindowWidth();
        }

        public async Task<int> GetWindowHeightAsync()
        {
            return await this.WindowSizeJsInterop.GetWindowHeight();
        }

        public async Task RegisterResizeCallback(DotNetObjectReference<SkillComponent> helper)
        {
            await this.WindowSizeJsInterop.RegisterResizeCallback(helper);
        }

        public async ValueTask DisposeAsync()
        {
            await this.WindowSizeJsInterop.DisposeAsync();
        }
        #endregion
    }
}

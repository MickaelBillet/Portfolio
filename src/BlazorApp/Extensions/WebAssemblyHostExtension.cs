using System.Globalization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp.Extensions
{
    public static class WebAssemblyHostExtension
    {
        public async static Task SetDefaultUICulture(this WebAssemblyHost host)
        {
            ILocalStorageService localStorage = host.Services.GetRequiredService<ILocalStorageService>();
            var result = await localStorage.GetItemAsync<string>("currentculture");
            CultureInfo culture;
            if (result != null)
                culture = new CultureInfo(result);
            else
                culture = new CultureInfo("en-US");

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}

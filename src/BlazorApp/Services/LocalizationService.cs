using BlazorApp.Models;
using Blazored.LocalStorage;

namespace BlazorApp.Services
{
    public sealed class LocalizationService
    {
        ILocalStorageService LocalStorage { get; set; }

        public LocalizationService(IServiceProvider serviceProvider)
        {
            this.LocalStorage = serviceProvider.GetRequiredService<ILocalStorageService>();
        }

        public async Task<int> GetLanguage()
        {
            return await this.LocalStorage.GetItemAsync<string>("currentculture") switch
            {
             "en-US" => Language.EnglishCode,
             "fr-FR" => Language.FrenchCode,
              _ => Language.EnglishCode 
            };
        }
    }
}

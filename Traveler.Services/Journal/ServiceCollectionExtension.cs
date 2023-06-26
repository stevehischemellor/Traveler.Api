using Microsoft.Extensions.DependencyInjection;

namespace Traveler.Services.Journal
{
    public static class ResumeServiceInjectionExtension
    {
        public static void AddJournalService(this IServiceCollection services)
        {
            services.AddScoped<IJournalService, JournalService>();
        }
    }
}

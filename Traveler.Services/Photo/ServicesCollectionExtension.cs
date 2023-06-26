using Microsoft.Extensions.DependencyInjection;

namespace Traveler.Services.Photo
{
    public static class ResumeServiceInjectionExtension
    {
        public static void AddPhotoService(this IServiceCollection services)
        {
            services.AddScoped<IPhotoService, PhotoService>();          
        }
    }
}

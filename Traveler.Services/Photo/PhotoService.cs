using Microsoft.Extensions.Logging;

namespace Traveler.Services.Photo
{
    public class PhotoService : IPhotoService
    {
        private readonly ILogger<PhotoService> _logger;

        public PhotoService(ILogger<PhotoService> logger)
        {
            _logger = logger;
        }

        public Task GetPhoto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
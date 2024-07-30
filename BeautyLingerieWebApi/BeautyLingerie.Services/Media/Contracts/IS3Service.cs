
using BeautyLingerie.ViewModels.Media;
using Microsoft.AspNetCore.Http;


namespace BeautyLingerie.Services.Media.Contracts
{
    public interface IS3Service
    {

        Task<bool> UploadFileAsync(IFormFile file, string bucketName, string? prefix);
        Task<List<S3ViewModel>> GetAllFilesAsync(string bucketName, string? prefix);
        Task<string> GetFileUrlByKeyAsync(string bucketName, string key);
        Task DeleteFileAsync(string bucketName, string nameOfObject);

    }

}

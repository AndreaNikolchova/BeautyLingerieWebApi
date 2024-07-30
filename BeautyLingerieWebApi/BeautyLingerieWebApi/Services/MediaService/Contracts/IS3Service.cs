using Amazon.S3.Transfer;
using Amazon.S3;
using BeautyLingerieWebApi.ViewModels;

namespace BeautyLingerieWebApi.Services.MediaService.Contracts
{
    public interface IS3Service
    {

        Task<bool> UploadFileAsync(IFormFile file, string bucketName, string? prefix);
        Task<List<S3ViewModel>> GetAllFilesAsync(string bucketName, string? prefix);
        Task<string> GetFileUrlByKeyAsync(string bucketName, string key);
        Task DeleteFileAsync(string bucketName, string nameOfObject);

    }

}

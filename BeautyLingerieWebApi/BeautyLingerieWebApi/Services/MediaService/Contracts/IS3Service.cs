using Amazon.S3.Transfer;
using Amazon.S3;

namespace BeautyLingerieWebApi.Services.MediaService.Contracts
{
    public interface IS3Service
    {

         Task<string> UploadFileAsync(IFormFile file);
       
    }

}

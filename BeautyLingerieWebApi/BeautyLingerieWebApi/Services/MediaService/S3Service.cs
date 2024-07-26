namespace BeautyLingerieWebApi.Services.MediaService
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    using Amazon.S3;
    using Amazon.S3.Transfer;

    using BeautyLingerieWebApi.Services.MediaService.Contracts;
    public class S3Service : IS3Service
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public S3Service(IAmazonS3 s3Client, string bucketName)
        {
            _s3Client = s3Client;
            _bucketName = bucketName;
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var fileTransferUtility = new TransferUtility(_s3Client);

            var key = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            using (var stream = file.OpenReadStream())
            {
                await fileTransferUtility.UploadAsync(stream, _bucketName, key);
            }

            return $"https://{_bucketName}.s3.amazonaws.com/{key}";
        }
    }

}

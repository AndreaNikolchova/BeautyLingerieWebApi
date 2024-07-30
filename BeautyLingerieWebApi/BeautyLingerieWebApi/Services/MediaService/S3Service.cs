namespace BeautyLingerieWebApi.Services.MediaService
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    using Amazon.S3;
    using Amazon.S3.Model;
  
    using BeautyLingerieWebApi.Services.MediaService.Contracts;
    using BeautyLingerieWebApi.ViewModels;
    using BeautyLingerieWebApi.Common;
    using Microsoft.AspNetCore.Mvc;

    public class S3Service : IS3Service
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public S3Service(IAmazonS3 s3Client, string bucketName)
        {
            _s3Client = s3Client;
            _bucketName = bucketName;
        }

        public async Task<bool> UploadFileAsync(IFormFile file, string bucketName, string? prefix)
        {
            var bucketExists = await _s3Client.DoesS3BucketExistAsync(bucketName);

            if (!bucketExists)
                throw new Exception(String.Format(ExeptionMessages.BucketNotFound, bucketName));

            var request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = string.IsNullOrEmpty(prefix) ? file.FileName : $"{prefix?.TrimEnd('/')}/{file.FileName}",
                InputStream = file.OpenReadStream()
            };
            request.Metadata.Add("Content-Type", file.ContentType);
            await _s3Client.PutObjectAsync(request);
            return true;
        }
        public async Task<List<S3ViewModel>> GetAllFilesAsync(string bucketName, string? prefix)
        {
            var bucketExists = await _s3Client.DoesS3BucketExistAsync(bucketName);

            if (!bucketExists) throw new Exception(String.Format(ExeptionMessages.BucketNotFound, bucketName));

            var request = new ListObjectsV2Request()
            {
                BucketName = bucketName,
                Prefix = prefix
            };
            var result = await _s3Client.ListObjectsV2Async(request);
            var s3Objects = result.S3Objects.Select(s =>
            {
                var urlRequest = new GetPreSignedUrlRequest()
                {
                    BucketName = bucketName,
                    Key = s.Key,
                    Expires = DateTime.UtcNow.AddMinutes(1)
                };
                return new S3ViewModel()
                {
                    Name = s.Key.ToString(),
                    PresignedUrl = _s3Client.GetPreSignedURL(urlRequest),
                };
            }).ToList();
            return s3Objects;
        }
       
        public async Task<string> GetFileUrlByKeyAsync(string bucketName, string key)
        {
            var bucketExists = await _s3Client.DoesS3BucketExistAsync(bucketName);
            if (!bucketExists) throw new Exception(String.Format(ExeptionMessages.BucketNotFound, bucketName));

            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Expires = DateTime.UtcNow.AddHours(1) 
            };

            string url = _s3Client.GetPreSignedURL(request);
            return url;
        }
        public async Task DeleteFileAsync(string bucketName, string nameOfObject)
        {
            var bucketExists = await _s3Client.DoesS3BucketExistAsync(bucketName);
            if (!bucketExists) throw new Exception(String.Format(ExeptionMessages.BucketNotFound,bucketName));
            await _s3Client.DeleteObjectAsync(bucketName, nameOfObject);
           
        }

    }
}

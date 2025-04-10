﻿namespace BeautyLingerie.Services.MediaService
{

    using CloudinaryDotNet.Actions;
    using CloudinaryDotNet;

    using BeautyLingerie.Services.MediaService.Contracts;

    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public async Task<ImageUploadResult> UploadAsync(ImageUploadParams parameters)
        {
            return await cloudinary.UploadAsync(parameters);
        }
    }
}

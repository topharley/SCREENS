using System;

namespace Screens.Uploaders
{
    class UploaderFactory
    {
        public static Uploader Create(UploaderType type)
        {
            switch (type)
            {
                case UploaderType.Cloudinary:
                    return new CloudinaryUploader();
                case UploaderType.Imgur:
                    return new ImgurUploader();
                case UploaderType.Pixs:
                    return new PixsRuUploader();
                case UploaderType.UploadsIm:
                    return new UploadsImUploader();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
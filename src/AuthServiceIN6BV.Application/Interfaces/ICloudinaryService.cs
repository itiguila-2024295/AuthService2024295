namespace AuthServiceIN6BV.Application.Interfaces;

public interface ICloudinaryService
{
    Task<String> UploadImageAsync(IFileData imageFile, string fileName);
    Task<bool> DeleteImageAsync (string publicId);
    string GetDefultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}